namespace WealthFarm.SparkPost.Transmission
{
    /// <summary>
    ///     Attachment is used for attaching files and inline-images to a transmission.
    /// </summary>
    public class Attachment
    {
        /// <summary>
        ///     Gets or sets the file name of the attachment or inline-image.
        /// </summary>
        /// <remarks>
        ///     For attachments:
        ///     This is inserted into the filename parameter of the Content-Disposition header.
        ///     For inline images:
        ///     This is the name of the inline image , which will be inserted into the Content-ID
        ///     header. The image should be referenced in your HTML content by setting the img tag's src attribute to
        ///     <c>cid:THIS_NAME</c>, where THIS_NAME is the value of this property.
        ///     The name must be unique within the content.inline_images array.
        /// </remarks>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the attachment or image type.
        /// </summary>
        /// <remarks>
        ///     For attachments:
        ///     The MIME type of the attachment; e.g., text/plain, image/jpeg, audio/mp3, video/mp4, application/msword,
        ///     application/pdf, etc., including the charset parameter (ex: text/html; charset="UTF-8") if needed.
        ///     The value will apply as-is to the Content-Type header of the generated MIME part for the attachment.
        ///     For inline images:
        ///     This is the MIME type of the image; e.g., image/jpeg. The value will apply as-is
        ///     to the Content-Type header of the generated MIME part for the image.
        /// </remarks>
        public string Type { get; set; }

        /// <summary>
        ///     Gets or sets the attachment or inline-image data.
        /// </summary>
        /// <remarks>
        ///     The content of the attachment or inline image as a Base64 encoded string. The string should not contain
        ///     line breaks (<c>\r\n</c>).
        /// </remarks>
        public string Data { get; set; }
    }
}