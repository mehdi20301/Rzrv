﻿using System;
using System.Net;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc;
using RZRV.Chat;
using RZRV.Storage;
using RZRV.Web.Areas.App.Models.Common.Modals;
using RZRV.Web.Controllers;
using Newtonsoft.Json.Linq;

namespace RZRV.Web.Areas.App.Controllers
{
    [Area("App")]
    [AbpMvcAuthorize]
    public class ChatController : ChatControllerBase
    {
        public ChatController(IBinaryObjectManager binaryObjectManager, IChatMessageManager chatMessageManager) :
            base(binaryObjectManager, chatMessageManager)
        {
        }

        public async Task<ActionResult> GetImage(int id, string contentType)
        {
            var message = await ChatMessageManager.FindMessageAsync(id, AbpSession.GetUserId());
            var jsonMessage = JObject.Parse(message.Message.Substring("[image]".Length));
            using (CurrentUnitOfWork.SetTenantId(null))
            {
                var fileObject = await BinaryObjectManager.GetOrNullAsync(Guid.Parse(((JValue)jsonMessage["id"]).Value.ToString()));
                if (fileObject == null)
                {
                    return StatusCode((int)HttpStatusCode.NotFound);
                }

                return File(fileObject.Bytes, contentType);
            }
        }

        public async Task<ActionResult> GetFile(int id, string contentType)
        {
            var message =await ChatMessageManager.FindMessageAsync(id, AbpSession.GetUserId());
            var jsonMessage = JObject.Parse(message.Message.Substring("[file]".Length));
            using (CurrentUnitOfWork.SetTenantId(null))
            {
                var fileObject = await BinaryObjectManager.GetOrNullAsync(Guid.Parse(((JValue)jsonMessage["id"]).Value.ToString()));
                if (fileObject == null)
                {
                    return StatusCode((int)HttpStatusCode.NotFound);
                }

                return File(fileObject.Bytes, contentType);
            }
        }
        
        public PartialViewResult AddFriendModal()
        {
            return PartialView("_AddFriendModal");
        }
        
        public PartialViewResult AddFromDifferentTenantModal()
        {
            return PartialView("_AddFromDifferentTenantModal");
        }
    }
}