﻿using DSC.Database.Domain;
using DSC.WebApi.Models;

namespace DSC.WebApi.Test
{
    static class Comparator
    {
        internal static bool JobsAreIdentical(Job reference, Job subject)
        {
            if (reference.Name == subject.Name && reference.IsCompleted == subject.IsCompleted)
            {
                return true;
            }
            return false;
        }
    }
}
