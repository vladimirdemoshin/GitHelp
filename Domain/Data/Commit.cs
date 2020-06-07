﻿namespace Domain.Data
{
    public class Commit
    {
        public string Message { get; protected set; }

        public Commit(string message)
        {
            Message = message;
        }
    }
}
