using System;

using R5T.Guide;


namespace R5T.Francia
{
    public class ImageIdentity : TypedGuid
    {
        public ImageIdentity(Guid value)
            : base(value)
        {
        }

        public ImageIdentity()
            : this(Guid.NewGuid())
        {
        }
    }
}
