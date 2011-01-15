﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LineString.cs" company="Jörg Battermann">
//   Copyright © Jörg Battermann 2011
// </copyright>
// <summary>
//   Defines the LineString type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GeoJSON.Net
{
    using System;
    using System.Collections.Generic;

    using GeoJSON.Net.Geometry;

    using Newtonsoft.Json;

    /// <summary>
    /// For type 'LineString', the 'Coordinates' member must be an array/list of two or more positions.
    /// </summary>
    /// <seealso cref="http://geojson.org/geojson-spec.html#linestring"/>
    [JsonObject(MemberSerialization.OptIn)]
    public class LineString : GeoJSONObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineString"/> class.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        public LineString(List<Position> coordinates)
        {
            if (coordinates == null)
            {
                throw new ArgumentNullException("coordinates");
            }

            if (coordinates.Count < 2)
            {
                throw new ArgumentOutOfRangeException("coordinates", "According to the GeoJSON v1.0 spec a LineString must have at least two or more positions.");
            }

            this.Coordinates = coordinates;
            this.Type = GeoJSONObjectType.LineString;
        }

        /// <summary>
        /// Gets the Positions.
        /// </summary>
        /// <value>The Positions.</value>
        [JsonProperty(PropertyName = "coordinates", Required = Required.Always)]
        public List<Position> Coordinates { get; private set; }

        /// <summary>
        /// Determines whether this LineString is a <see cref="http://geojson.org/geojson-spec.html#linestring">LinearRing</see>.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if it is a linear ring; otherwise, <c>false</c>.
        /// </returns>
        public bool IsLinearRing()
        {
            return this.Coordinates.Count >= 4 && this.Coordinates[0].Equals(this.Coordinates[this.Coordinates.Count - 1]);
        }
    }
}
