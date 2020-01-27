using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TRPTools.Models;

namespace TRPTools.ViewModels
{
    public class AddOrderViewModel
    {
        [Required]
        public List<SelectListItem> CupType { get; set; }

        public List<SelectListItem> Glitter { get; set; }

        public AddOrderViewModel(IEnumerable<CupType> cupTypes)
        {

            CupType = new List<SelectListItem>();
            foreach (var type in cupTypes)
            {
                CupType.Add(new SelectListItem
                {
                    Value = type.CupTypeID.ToString(),
                    Text = type.CupTypeDesc
                });
            }

        }

        public AddOrderViewModel(IEnumerable<Glitter> glitters)
        {

            Glitter = new List<SelectListItem>();
            foreach (var type in glitters)
            {
                Glitter.Add(new SelectListItem
                {
                    Value = type.GlitterID.ToString(),
                    Text = type.GlitterName
                });
            }

        }
    }
}
