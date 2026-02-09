using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthcareIntakeDemo.ViewmodelLayer
{
    // Represents a single dropdown answer option for a question
    public class QuestionnaireViewmodel
    {
        public string QuestionTitle { get; set; }

        // Selected value from the dropdown (may be null)
        public string SelectedValue { get; set; }

        // Dropdown options as SelectListItem for use in views
        public List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> AnswerOptions { get; set; }

        public QuestionnaireViewmodel()
        {
            AnswerOptions = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();
        }

        public QuestionnaireViewmodel(string title, IEnumerable<string> options, string selectedValue = null)
        {
            QuestionTitle = title;
            SelectedValue = selectedValue;
            AnswerOptions = options?
                .Select(o => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
                {
                    Text = o,
                    Value = o,
                    Selected = o == selectedValue
                })
                .ToList() ?? new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();
        }
    }
}