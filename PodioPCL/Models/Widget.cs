using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace PodioPCL.Models
{
	/// <summary>
	/// Class Widget.
	/// </summary>
    public class Widget
    {
		/// <summary>
		/// Gets or sets the widget identifier.
		/// </summary>
		/// <value>The widget identifier.</value>
        [JsonProperty("widget_id")]
        public int? WidgetId { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
        [JsonProperty("title")]
        public string Title { get; set; }

		/// <summary>
		/// Gets or sets the configuration.
		/// </summary>
		/// <value>The configuration.</value>
        [JsonProperty("config")]
        public JObject Config { get; set; }

		/// <summary>
		/// Gets or sets the rights.
		/// </summary>
		/// <value>The rights.</value>
        [JsonProperty("rights")]
        public string[] Rights { get; set; }

		/// <summary>
		/// Gets or sets the data.
		/// </summary>
		/// <value>The data.</value>
        [JsonProperty("data")]
        public JToken Data { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		/// <value>The created by.</value>
        [JsonProperty("created_by")]
        public ByLine CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the created on.
		/// </summary>
		/// <value>The created on.</value>
        [JsonProperty("created_on")]
        public DateTime? CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the reference.
		/// </summary>
		/// <value>The reference.</value>
        [JsonProperty("ref")]
        public Reference Ref { get; set; }

		/// <summary>
		/// Gets or sets the allowed refs.
		/// </summary>
		/// <value>The allowed refs.</value>
        [JsonProperty("allowed_refs")]
        public string[] AllowedRefs { get; set; }

		/// <summary>
		/// Gets or sets the cols.
		/// </summary>
		/// <value>The cols.</value>
        [JsonProperty("cols")]
        public int Cols { get; set; }

		/// <summary>
		/// Gets or sets the rows.
		/// </summary>
		/// <value>The rows.</value>
        [JsonProperty("rows")]
        public int Rows { get; set; }

		/// <summary>
		/// Gets or sets the x.
		/// </summary>
		/// <value>The x.</value>
        [JsonProperty("x")]
        public int X { get; set; }

		/// <summary>
		/// Gets or sets the y.
		/// </summary>
		/// <value>The y.</value>
        [JsonProperty("y")]
        public int Y { get; set; }
    }
}
