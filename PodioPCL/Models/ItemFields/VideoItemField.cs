using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace PodioPCL.Models.ItemFields
{
	public class VideoItemField: ItemField
    {
        private List<FileAttachment> _videos;

        public IEnumerable<FileAttachment> Videos
        {
            get
            {
                return this.valuesAs<FileAttachment>(_videos);
            }
        }

        public IEnumerable<int> FileIds
        {
            set
            {
                ensureValuesInitialized();
                foreach (var fileId in value)
                {
                    var jobject = new JObject();
                    jobject["value"] = fileId;
                    this.Values.Add(jobject);
                }
            }
        }
        public int  FileId
        {
            set
            {
                ensureValuesInitialized();
                
                    var jobject = new JObject();
                    jobject["value"] = value;
                    this.Values.Add(jobject);
                
            }
        }
    }
}
