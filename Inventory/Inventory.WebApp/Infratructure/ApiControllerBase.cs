using Inventory.Model.Models;
using Inventory.Service.Interface;
using Inventory.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Inventory.WebApp.Infratructure
{
    public class ApiControllerBase : ApiController
    {

        private IErorrSerivce _errorService;
        public ApiControllerBase(IErorrSerivce errorService)
        {
            this._errorService = errorService;
        }


        protected HttpResponseMessage CreateHttpResponse(HttpResponseMessage requestMessage, Func<HttpResponseMessage> func)
        {
            return null;
        }




        private void LogError(Exception ex)
        {
            try
            {
                Error error = new Error();
                error.CreatedDate = DateTime.Now;
                error.Message = ex.Message;
                error.StackTrace = ex.StackTrace;
                _errorService.Create(error);
                _errorService.Save();
            }
            catch
            {

            }
        }


    }
}