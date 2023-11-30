using AutoMapper;
using BlazorBootstrap;
using ClubModels.Models;
using ClubModels.Models.GeneralCodes;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Web;
using System.Collections.Generic;
using System.Net.Http.Json;

namespace ClubUI.Pages.GeneralCodes.Model
{
    public class CodeViewModel<T, TCDTO, TEDTO> where T : Codes, new()
    {
        public List<T> Entities { get; set; } = new List<T> ();
        public T SelectedEntity { get; set; } = new T();
        public bool IsNew { get; set; }
        public SortDirection CodeSort { get; set; }
        public AlertColor CallType { get; set; }
        public string LastSubmitResult { get; set; }
        public string APIURL { get; set; }
        public Modal DeleteVerifyModal { get; set; }

        public async Task OnRowClick(GridRowEventArgs<T> args, IMapper mapper)
        {
            SelectedEntity = mapper.Map<T>(args.Item);
            IsNew = false;
        }

        public void MakeNew(MouseEventArgs e)
        {
            IsNew = true;
            SelectedEntity = new T();
            SelectedEntity.Code = Entities.OrderByDescending(e => e.Code).First().Code + 1;
        }

        public async void OnDeleteVerifyShow()
        {
            await DeleteVerifyModal?.ShowAsync();
        }

        public async void OnDeleteVerifyHide()
        {
            await DeleteVerifyModal?.HideAsync();
        }

        public async Task DeleteEntity(HttpClient Http)
        {
            if (SelectedEntity == null)
            {
                LastSubmitResult = "No Code Selected To Delete";
                CallType = AlertColor.Danger;
                return;
            }

            var response = await Http.DeleteAsync($"{APIURL}/{SelectedEntity.Id}");
            var content = response.Content.ReadAsStream();
            if (!response.IsSuccessStatusCode)
            {
                LastSubmitResult = new StreamReader(content).ReadToEnd();
                CallType = AlertColor.Danger;
            }
            else
            {
                LastSubmitResult = "Code Removed Successfully";
                Entities = await Http.GetFromJsonAsync<List<T>>(APIURL) ?? new List<T>();
                CallType = AlertColor.Success;
                SelectedEntity = new();
            }
            await DeleteVerifyModal?.HideAsync();
        }
        public async Task FormSubmitted(EditContext editContext, HttpClient Http, IMapper Mapper)
        {
            if (editContext.Validate())
            {
                if (IsNew)
                {
                    var newEntity = Mapper.Map<TCDTO>(SelectedEntity);

                    var response = await Http.PostAsJsonAsync(APIURL, newEntity);
                    var content = response.Content.ReadAsStream();
                    if (!response.IsSuccessStatusCode)
                    {
                        LastSubmitResult = new StreamReader(content).ReadToEnd(); ;
                        CallType = AlertColor.Danger;
                    }
                    else
                    {
                        LastSubmitResult = "Code Added Successfully";
                        Entities = await Http.GetFromJsonAsync<List<T>>(APIURL) ?? new List<T>();
                        CallType = AlertColor.Success;
                        CodeSort = SortDirection.Descending;
                        SelectedEntity = new();
                    }
                }
                else
                {
                    var newEntity = Mapper.Map<TEDTO>(SelectedEntity);
                    var response = await Http.PutAsJsonAsync($"{APIURL}/{SelectedEntity.Id}", newEntity);
                    var content = response.Content.ReadAsStream();
                    if (!response.IsSuccessStatusCode)
                    {
                        LastSubmitResult = new StreamReader(content).ReadToEnd();
                        CallType = AlertColor.Danger;
                    }
                    else
                    {
                        LastSubmitResult = "Code Updated Successfully";
                        Entities = await Http.GetFromJsonAsync<List<T>>(APIURL) ?? new List<T>();
                        CallType = AlertColor.Success;
                        CodeSort = SortDirection.Descending;
                        SelectedEntity = new();
                    }
                }
            }
        }
    }
}
