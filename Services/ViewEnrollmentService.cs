using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using StudentUasOrlando.Models;
using StudentUasOrlando.Services;

namespace StudentUasOrlando.Services
{
    public class ViewEnrollmentService : IViewEnrollmentService
     {
        private HttpClient _httpClient;

        public ViewEnrollmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<ViewEnrollment> Delete(int id)
        {
            throw new System.NotImplementedException();
        }
        public async Task<IEnumerable<ViewEnrollment>> GetAll()
        {
            var hasil = await _httpClient.GetFromJsonAsync<IEnumerable<ViewEnrollment>>("/api/ViewEnrollments");
            return hasil;
        }

        public async Task<ViewEnrollment> GetById(int id)
        {
            var hasil1 = await _httpClient.GetFromJsonAsync<ViewEnrollment>($"/api/ViewEnrollments/{id}");
            return hasil1;
        }
      
        public async Task<ViewEnrollment> Update(int id, ViewEnrollment viewEnrollment)
        {
            var response = await _httpClient.PutAsJsonAsync($"/api/ViewEnrollments/{id}",viewEnrollment);
            if(response.IsSuccessStatusCode){
                return await JsonSerializer.DeserializeAsync<ViewEnrollment>(await response.Content.ReadAsStreamAsync());
            }
            else{
                throw new Exception("Gagal update student");
            }
        }
        public async Task<ViewEnrollment> Add(ViewEnrollment obj){
            var response = await _httpClient.PostAsJsonAsync($"/api/ViewEnrollments", obj);
            if(response.IsSuccessStatusCode){
            return await JsonSerializer.DeserializeAsync<ViewEnrollment>(await response.Content.ReadAsStreamAsync());
            }
            else{
                throw new Exception("gagal tambah data student");

        }
        }
    }
}
