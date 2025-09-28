using System.Globalization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Lesnichestvo.Binders
{
    public class MyDecimalBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            if (valueProviderResult == ValueProviderResult.None)
                return Task.CompletedTask;

            bindingContext.ModelState.SetModelValue(bindingContext.ModelName, valueProviderResult);

            var value = valueProviderResult.FirstValue;

            if (string.IsNullOrWhiteSpace(value))
                return Task.CompletedTask;

            value = value.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                         .Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (decimal.TryParse(value, NumberStyles.Any, CultureInfo.CurrentCulture, out var result))
            {
                bindingContext.Result = ModelBindingResult.Success(result);
            }
            else
            {
                bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, "Неверный формат числа.");
            }

            return Task.CompletedTask;
        }
    }
}
