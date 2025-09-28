using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Lesnichestvo.Binders
{
    public class MyDecimalBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);

            var type = context.Metadata.ModelType;

            if (type == typeof(decimal) || type == typeof(decimal?))
            {
                return new MyDecimalBinder();
            }

            return null!;
        }
    }

}
