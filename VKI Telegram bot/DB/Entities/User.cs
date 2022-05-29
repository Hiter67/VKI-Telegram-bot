﻿using System.ComponentModel.DataAnnotations;

namespace VKI_Telegram_bot.DB.Entities
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string? Name { get; set; }
    }
}
