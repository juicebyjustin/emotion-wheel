//Autogenerated by BlazorBoilerplate.EntityGenerator
using BlazorBoilerplate.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BlazorBoilerplate.Shared.DataInterfaces
{
    public interface IEmotion
    {
        Int64 Id { get; set; }

        String Title { get; set; }

        IEmotionCategory EmotionCategory { get; set; }

        DateTime CreatedOn { get; set; }

        DateTime? ModifiedOn { get; set; }

        IApplicationUser CreatedBy { get; set; }

        Guid? CreatedById { get; set; }

        IApplicationUser ModifiedBy { get; set; }

        Guid? ModifiedById { get; set; }

        bool IsDeleted { get; set; }

    }
}
