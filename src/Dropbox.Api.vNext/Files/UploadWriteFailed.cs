// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The upload write failed object</para>
    /// </summary>
    public class UploadWriteFailed
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UploadWriteFailed> Encoder = new UploadWriteFailedEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UploadWriteFailed> Decoder = new UploadWriteFailedDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadWriteFailed" />
        /// class.</para>
        /// </summary>
        /// <param name="reason">The reason why the file couldn't be saved.</param>
        /// <param name="uploadSessionId">The upload session ID; this may be used to retry the
        /// commit.</param>
        public UploadWriteFailed(WriteError reason,
                                 string uploadSessionId)
        {
            if (reason == null)
            {
                throw new sys.ArgumentNullException("reason");
            }

            if (uploadSessionId == null)
            {
                throw new sys.ArgumentNullException("uploadSessionId");
            }

            this.Reason = reason;
            this.UploadSessionId = uploadSessionId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadWriteFailed" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public UploadWriteFailed()
        {
        }

        /// <summary>
        /// <para>The reason why the file couldn't be saved.</para>
        /// </summary>
        public WriteError Reason { get; protected set; }

        /// <summary>
        /// <para>The upload session ID; this may be used to retry the commit.</para>
        /// </summary>
        public string UploadSessionId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UploadWriteFailed" />.</para>
        /// </summary>
        private class UploadWriteFailedEncoder : enc.StructEncoder<UploadWriteFailed>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UploadWriteFailed value, enc.IJsonWriter writer)
            {
                WriteProperty("reason", value.Reason, writer, Dropbox.Api.Files.WriteError.Encoder);
                WriteProperty("upload_session_id", value.UploadSessionId, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UploadWriteFailed" />.</para>
        /// </summary>
        private class UploadWriteFailedDecoder : enc.StructDecoder<UploadWriteFailed>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UploadWriteFailed" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UploadWriteFailed Create()
            {
                return new UploadWriteFailed();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UploadWriteFailed value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "reason":
                        value.Reason = Dropbox.Api.Files.WriteError.Decoder.Decode(reader);
                        break;
                    case "upload_session_id":
                        value.UploadSessionId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
