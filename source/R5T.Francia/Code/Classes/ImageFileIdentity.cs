using System;

using R5T.Guide;


namespace R5T.Francia
{
    public class ImageFileIdentity : TypedGuid
    {
        #region Static

        public static ImageFileIdentity New()
        {
            var output = new ImageFileIdentity();
            return output;
        }

        public static ImageFileIdentity From(Guid value)
        {
            var output = new ImageFileIdentity(value);
            return output;
        }

        #endregion


        public ImageFileIdentity(Guid value)
            : base(value)
        {
        }

        public ImageFileIdentity()
            : this(Guid.NewGuid())
        {
        }
    }
}
