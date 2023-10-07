﻿using System.Collections.Generic;
using System.ComponentModel;
using MathNet.Numerics.Interpolation;

namespace Bonsai.Numerics.Interpolation
{
    [Description("Creates a sequence of interpolation objects based on arbitrary points.")]
    public class CreateCommon : InterpolationBase
    {
        protected override IInterpolation CreateInterpolation(IEnumerable<double> points, IEnumerable<double> values)
        {
            return MathNet.Numerics.Interpolate.Common(points, values);
        }
    }
}
