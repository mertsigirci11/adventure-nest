﻿using System;

namespace AdventureNest.Core.DTOs
{
    public abstract class BaseDto
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
