// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The revoke linked app batch result object</para>
    /// </summary>
    public class RevokeLinkedAppBatchResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RevokeLinkedAppBatchResult> Encoder = new RevokeLinkedAppBatchResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RevokeLinkedAppBatchResult> Decoder = new RevokeLinkedAppBatchResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RevokeLinkedAppBatchResult" />
        /// class.</para>
        /// </summary>
        /// <param name="revokeLinkedAppStatus">The revoke linked app status</param>
        public RevokeLinkedAppBatchResult(col.IEnumerable<RevokeLinkedAppStatus> revokeLinkedAppStatus)
        {
            var revokeLinkedAppStatusList = enc.Util.ToList(revokeLinkedAppStatus);

            if (revokeLinkedAppStatus == null)
            {
                throw new sys.ArgumentNullException("revokeLinkedAppStatus");
            }

            this.RevokeLinkedAppStatus = revokeLinkedAppStatusList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RevokeLinkedAppBatchResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public RevokeLinkedAppBatchResult()
        {
        }

        /// <summary>
        /// <para>Gets the revoke linked app status of the revoke linked app batch
        /// result</para>
        /// </summary>
        public col.IList<RevokeLinkedAppStatus> RevokeLinkedAppStatus { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RevokeLinkedAppBatchResult" />.</para>
        /// </summary>
        private class RevokeLinkedAppBatchResultEncoder : enc.StructEncoder<RevokeLinkedAppBatchResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RevokeLinkedAppBatchResult value, enc.IJsonWriter writer)
            {
                WriteListProperty("revoke_linked_app_status", value.RevokeLinkedAppStatus, writer, Dropbox.Api.Team.RevokeLinkedAppStatus.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RevokeLinkedAppBatchResult" />.</para>
        /// </summary>
        private class RevokeLinkedAppBatchResultDecoder : enc.StructDecoder<RevokeLinkedAppBatchResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RevokeLinkedAppBatchResult"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RevokeLinkedAppBatchResult Create()
            {
                return new RevokeLinkedAppBatchResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RevokeLinkedAppBatchResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "revoke_linked_app_status":
                        value.RevokeLinkedAppStatus = ReadList<RevokeLinkedAppStatus>(reader, Dropbox.Api.Team.RevokeLinkedAppStatus.Decoder);
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
