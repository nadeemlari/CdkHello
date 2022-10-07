using Amazon.CDK;
using Amazon.CDK.AWS.S3;

using Constructs;

namespace CdkHello
{
    public class CdkHelloStack : Stack
    {
        internal CdkHelloStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            new Bucket(this, "MyFirstBucket", new BucketProps
            {
                Versioned = true,
                RemovalPolicy = RemovalPolicy.DESTROY
            });
        }
    }
}
