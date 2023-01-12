namespace SimmakersTestTask.Utils
{
    public static class ImageHtmlHelper
    {
        public static string GenerateImageSrc(string? imageName, byte[]? imageData)
        {
            if (imageName != null && imageData != null)
            {
                var extension = imageName.Substring(imageName.Length - 3, 3);

                string contentType = null;

                if (extension == "jpg")
                {
                    contentType = "image/jpeg";
                }

                if (extension == "png")
                {
                    contentType = "image/png";
                }

                return $"data:{contentType};base64," + Convert.ToBase64String(imageData, 0, imageData.Length);
            }
            else
            {
                return  "/images/DefaultAvatar.jpg";
            }
        }
    }
}
