#region Using Statements
using System;
using WaveEngine.Common;
using WaveEngine.Common.Graphics;
using WaveEngine.Common.Math;
using WaveEngine.Components.Cameras;
using WaveEngine.Components.Graphics2D;
using WaveEngine.Components.Graphics3D;
using WaveEngine.Framework;
using WaveEngine.Framework.Graphics;
using WaveEngine.Framework.Resources;
using WaveEngine.Framework.Services;
#endregion

namespace TestCube
{
    public class MyScene : Scene
    {
        protected override void CreateScene()
        {
            this.Load(WaveContent.Scenes.MyScene);

            var cube = new Entity()
                .AddComponent(new Transform3D())
                .AddComponent(new MaterialsMap())
                .AddComponent(Model.CreateCube())
                .AddComponent(new ModelRenderer())
                .AddComponent(new Spinner()
                {
                    AxisTotalIncreases = new Vector3(0, MathHelper.ToRadians(50), 0)
                });
            this.EntityManager.Add(cube);
        }
    }
}
