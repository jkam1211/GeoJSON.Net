﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGeometryObject.cs" company="Joerg Battermann">
//   Copyright © Joerg Battermann 2014
// </copyright>
// <summary>
//   Defines the IGeometryObject type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GeoJSON.Net.Geometry
{
    /// <summary>
    /// Base Interface for GeometryObject types.
    /// </summary>
    public interface IGeometryObject
    {
        /// <summary>
        /// Gets the (mandatory) type of the <see cref="https://tools.ietf.org/html/rfc7946#section-3.1">GeoJSON Object</see>.
        /// However, for <see cref="https://tools.ietf.org/html/rfc7946#section-3.1">GeoJSON Objects</see> only
        /// the 'Point', 'MultiPoint', 'LineString', 'MultiLineString', 'Polygon', 'MultiPolygon', or 'GeometryCollection' types are allowed.
        /// </summary>
        /// <value>
        /// The type of the object.
        /// </value>
        GeoJSONObjectType Type { get; }
    }
}
