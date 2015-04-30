using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ViewModels
{
    [DataContract]
    public class CatVM
    {
        [DataMember]
        public virtual int Id { get; set; }
        [Display(Name = "Category Name")]
        [DataMember]
        public virtual string Name { get; set; }
        [Display(Name = "Category Description")]
        [DataMember]
        public virtual string Description { get; set; }
        [DataMember]
        public virtual bool Active { get; set; }
    }
}