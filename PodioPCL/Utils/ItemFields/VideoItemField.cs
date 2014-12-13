using Newtonsoft.Json.Linq;
using PodioPCL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodioPCL.Utils.ItemFields
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
