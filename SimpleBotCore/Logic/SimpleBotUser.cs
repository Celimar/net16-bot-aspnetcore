﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBotCore.Logic
{
    public class SimpleBotUser
    {
        public string Reply(SimpleMessage message)
        {
            BotDAO botDAO = new BotDAO();

            botDAO.connection(message);

            return $"{message.User} disse '{message.Text}'";
        }

    }
}