using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class DecimalModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            // Check if the value provider contains the value for the model
            var valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            if (valueProviderResult == ValueProviderResult.None)
            {
                return Task.CompletedTask;
            }

            bindingContext.ModelState.SetModelValue(bindingContext.ModelName, valueProviderResult);

            var valueAsString = valueProviderResult.FirstValue;

            if (string.IsNullOrEmpty(valueAsString))
            {
                return Task.CompletedTask;
            }

            // Attempt to parse the value using the current culture
            if (!decimal.TryParse(valueAsString, NumberStyles.Any, CultureInfo.CurrentCulture, out var result) &&
                !decimal.TryParse(valueAsString, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, "The field must be a number.");
                return Task.CompletedTask;
            }

            bindingContext.Result = ModelBindingResult.Success(result);
            return Task.CompletedTask;
        }
    }
}
