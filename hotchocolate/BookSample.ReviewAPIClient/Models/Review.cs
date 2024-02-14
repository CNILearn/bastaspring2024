// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace BookSample.ReviewAPIClient.Models {
    public class Review : IParsable {
        /// <summary>The bookId property</summary>
        public long? BookId { get; set; }
        /// <summary>The id property</summary>
        public long? Id { get; set; }
        /// <summary>The stars property</summary>
        public int? Stars { get; set; }
        /// <summary>The text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>The username property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Username { get; set; }
#nullable restore
#else
        public string Username { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Review CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Review();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bookId", n => { BookId = n.GetLongValue(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"stars", n => { Stars = n.GetIntValue(); } },
                {"text", n => { Text = n.GetStringValue(); } },
                {"username", n => { Username = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("bookId", BookId);
            writer.WriteLongValue("id", Id);
            writer.WriteIntValue("stars", Stars);
            writer.WriteStringValue("text", Text);
            writer.WriteStringValue("username", Username);
        }
    }
}
