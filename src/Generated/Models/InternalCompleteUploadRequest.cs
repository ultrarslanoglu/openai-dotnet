// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Files
{
    internal partial class InternalCompleteUploadRequest
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        public InternalCompleteUploadRequest(IEnumerable<string> partIds)
        {
            Argument.AssertNotNull(partIds, nameof(partIds));

            PartIds = partIds.ToList();
        }

        internal InternalCompleteUploadRequest(IList<string> partIds, string md5, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PartIds = partIds;
            Md5 = md5;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalCompleteUploadRequest()
        {
        }

        public IList<string> PartIds { get; }
        public string Md5 { get; set; }
    }
}