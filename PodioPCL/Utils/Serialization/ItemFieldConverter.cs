using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PodioPCL.Models;
using PodioPCL.Models.ItemFields;
using System;

namespace PodioPCL.Utils.Serialization
{
	internal class ItemFieldConverter : CustomCreationConverter<ItemField>
	{
		public override bool CanConvert(Type objectType)
		{
			var canConvert = base.CanConvert(objectType);
			return canConvert;
		}

		public override Newtonsoft.Json.Schema.JsonSchema GetSchema()
		{
			var schema = base.GetSchema();
			return schema;
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var jsonItemField = base.ReadJson(reader, objectType, existingValue, serializer);
			if (jsonItemField != null && jsonItemField.GetType() == typeof(ItemField))
			{
				var field = (ItemField)jsonItemField;
				ItemFieldTypes fieldType = ItemFieldTypes.Other;
				Enum.TryParse(field.Type, true, out fieldType);

				switch (fieldType)
				{
					case ItemFieldTypes.App:
						return field.ConvertTo<AppItemField>();
					case ItemFieldTypes.Category:
						return field.ConvertTo<CategoryItemField>();
					case ItemFieldTypes.Contact:
						return field.ConvertTo<ContactItemField>();
					case ItemFieldTypes.Date:
						return field.ConvertTo<DateItemField>();
					case ItemFieldTypes.Duration:
						return field.ConvertTo<DurationItemField>();
					case ItemFieldTypes.Embed:
						return field.ConvertTo<EmbedItemField>();
					case ItemFieldTypes.Image:
						return field.ConvertTo<ImageItemField>();
					case ItemFieldTypes.Location:
						return field.ConvertTo<LocationItemField>();
					case ItemFieldTypes.Member:
						return field.ConvertTo<MemberItemField>();
					case ItemFieldTypes.Money:
						return field.ConvertTo<MoneyItemField>();
					case ItemFieldTypes.Number:
						return field.ConvertTo<NumericItemField>();
					case ItemFieldTypes.Progress:
						return field.ConvertTo<ProgressItemField>();
					case ItemFieldTypes.Question:
						return field.ConvertTo<QuestionItemField>();
					case ItemFieldTypes.State:
						return field.ConvertTo<StateItemField>();
					case ItemFieldTypes.Text:
						return field.ConvertTo<TextItemField>();
					case ItemFieldTypes.Video:
						return field.ConvertTo<VideoItemField>();
				}
			}
			return jsonItemField;
		}

		public override ItemField Create(Type objectType)
		{
			var dis = this;
			return new ItemField();
		}
	}
}
