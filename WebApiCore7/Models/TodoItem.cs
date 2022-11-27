﻿namespace WebApiCore7.Models
{
    // Model classes can go anywhere in the project, but the Models folder is used by convention.

    public class TodoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }  // in order to prevent over posting
    }
}
