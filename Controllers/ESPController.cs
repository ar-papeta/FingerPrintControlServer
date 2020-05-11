using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace ESP8266HTTPServer.Controllers
{
    public class ESPController : Controller
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("1195801945:AAFcqEJk-v4JevHXlcizKjaUWMN0w-Gxzrk");
        private static readonly long TelegramChatID = -469349740;

        [HttpGet]
        [Route("ESP/FingerAdd/{fingerprintId}")]
        public int FingerAdd(int fingerprintId)
        {
            return fingerprintId;
        }

        [HttpGet]
        [Route("ESP/FingerDelete/{fingerprintId}")]
        public void FingerDelete(int fingerprintId)
        {
            //return fingerprintId;
        }

        [HttpGet]
        [Route("ESP/FingerEnter/{fingerprintId}")]
        public async void FingerEnter(int fingerprintId)
        {
            String user;
            if(fingerprintId == 13)
            {
                user = "Artem Papeta";
            }
            else if(fingerprintId == 5)
            {
                user = "Petro ";
            }
            else if(fingerprintId == 6)
            {
                user = "Sergey";
            }
            else if (fingerprintId == 9)
            {
                user = "Dima";
            }
            else if (fingerprintId == 19)
            {
                user = "Sergey Velikolepnyy";
            }
            else if (fingerprintId == 4)
            {
                user = "Sasha Novikov";
            }
            else if (fingerprintId == 7)
            {
                user = "Dima";
            }
            else if (fingerprintId == 3)
            {
                user = "Kirill";
            }
            else if (fingerprintId == 20)
            {
                user = "Sasha BOTEON";
            }
            else if (fingerprintId == 17)
            {
                user = "Alexander Slusar";
            }
            else
            {
                user = $"ANONIMOUS USER with id {fingerprintId}";
            }
            await Bot.SendTextMessageAsync(TelegramChatID, $"{user} enter at {DateTime.Now.AddHours(3)}");
        }

        [HttpGet]
        [Route("ESP/FingerOUT/{fingerprintId}")]
        public async void FingerOut(int fingerprintId)
        {
            String user;
            if (fingerprintId == 13)
            {
                user = "Artem Papeta";
            }
            else if (fingerprintId == 5)
            {
                user = "Petro ";
            }
            else if (fingerprintId == 6)
            {
                user = "Sergey";
            }
            else if (fingerprintId == 9)
            {
                user = "Dima";
            }
            else if (fingerprintId == 19)
            {
                user = "Sergey Velikolepnyy";
            }
            else if (fingerprintId == 4)
            {
                user = "Sasha Novikov";
            }
            else if (fingerprintId == 7)
            {
                user = "Dima";
            }
            else if (fingerprintId == 3)
            {
                user = "Kirill";
            }
            else if (fingerprintId == 20)
            {
                user = "Sasha BOTEON";
            }
            else if (fingerprintId == 17)
            {
                user = "Alexander Slusar";
            }
            
            else
            {
                user = $"ANONIMOUS USER with id {fingerprintId}";
            }
            await Bot.SendTextMessageAsync(TelegramChatID, $"{user} out at {DateTime.Now.AddHours(3)}");
        }


    }
}