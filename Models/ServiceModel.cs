using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceDemo.Models
{
    public class ServiceModel
    {
        [Required]
        public string service { get; set; }
        public DateTime date { get; set; }

        public ServiceModel(string service, DateTime date)
        {
            this.service = service;
            this.date = date;
        }

        public ServiceModel()
        {

        }
    }
}
