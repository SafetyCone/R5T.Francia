using System;

using R5T.Guide;


namespace R5T.Francia
{
    public class ImageFileIdentity : TypedGuid
    {
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
