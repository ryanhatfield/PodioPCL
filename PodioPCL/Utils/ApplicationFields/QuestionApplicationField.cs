using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PodioPCL.Models;
using PodioPCL.Models.ItemFields;
using System.Collections.Generic;

namespace PodioPCL.Utils.ApplicationFields
{
	/// <summary>
	/// Class QuestionApplicationField.
	/// </summary>
	public class QuestionApplicationField : ApplicationField
	{
		[JsonIgnore]
		IEnumerable<CategoryItemField.Option> _options;

		/// <summary>
		/// The list of options for the question
		/// </summary>
		/// <value>The options.</value>
		public IEnumerable<CategoryItemField.Option> Options
		{
			get
			{
				if (_options == null)
				{
					_options = this.GetSettingsAs<CategoryItemField.Option>("options");
				}
				return _options;
			}
			set
			{
				InitializeFieldSettings();
				this.InternalConfig.Settings["options"] = value != null ? JToken.FromObject(value) : null;
			}
		}

		/// <summary>
		/// True if multiple options should be allowed, False otherwise
		/// </summary>
		/// <value><c>true</c> if multiple; otherwise, <c>false</c>.</value>
		public bool Multiple
		{
			get
			{
				return (bool)this.GetSetting("multiple");
			}
			set
			{
				InitializeFieldSettings();
				this.InternalConfig.Settings["multiple"] = value;
			}
		}

	}
}
