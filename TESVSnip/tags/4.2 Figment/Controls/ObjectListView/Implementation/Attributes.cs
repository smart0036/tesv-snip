﻿/*
 * Attributes - Attributes that can be attached to properties of models to allow columns to be
 *              built from them directly
 *
 * Author: Phillip Piper
 * Date: 15/08/2009 22:01
 *
 * Change log:
 * v2.4
 * 2010-04-14  JPP  - Allow Name property to be set
 * 
 * v2.3
 * 2009-08-15  JPP  - Initial version
 *
 * To do:
 * 
 * Copyright (C) 2009-2010 Phillip Piper
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
 * If you wish to use this code in a closed source application, please contact phillip_piper@bigfoot.com.
 */

using System;
using System.Windows.Forms;

namespace BrightIdeasSoftware
{
    /// <summary>
    /// This attribute is used to mark a field, property, or parameter-less method of a model
    /// class that should be noticed by Generator class.
    /// </summary>
    /// <remarks>
    /// All the attributes of this class match their equivilent properties on OLVColumn.
    /// </remarks>
    public class OLVColumnAttribute : Attribute
    {
        #region Constructor

        /// <summary>
        /// Create a new OLVColumnAttribute
        /// </summary>
        public OLVColumnAttribute()
        {
        }

        /// <summary>
        /// Create a new OLVColumnAttribute with the given title
        /// </summary>
        /// <param name="title">The title of the column</param>
        public OLVColumnAttribute(string title)
        {
            Title = title;
        }

        #endregion

        #region Public properties

        /// <summary>
        /// 
        /// </summary>
        public string AspectToStringFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool CheckBoxes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int DisplayIndex
        {
            get { return displayIndex; }
            set { displayIndex = value; }
        }

        private int displayIndex = -1;

        /// <summary>
        /// 
        /// </summary>
        public bool FillsFreeSpace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? FreeSpaceProportion { get; set; }

        /// <summary>
        /// An array of IComparables that mark the cutoff points for values when
        /// grouping on this column. 
        /// </summary>
        public object[] GroupCutoffs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string[] GroupDescriptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string GroupWithItemCountFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string GroupWithItemCountSingularFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Hyperlink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ImageAspectName { get; set; }

        // We actually want this to be bool? but it seems attribute properties can't be nullable types.
        // So we explicitly track if the property has been set.

        /// <summary>
        /// 
        /// </summary>
        public bool IsEditable
        {
            get { return isEditable; }
            set
            {
                isEditable = value;
                IsEditableSet = true;
            }
        }

        private bool isEditable = true;
        internal bool IsEditableSet;

        /// <summary>
        /// 
        /// </summary>
        public bool IsVisible
        {
            get { return isVisible; }
            set { isVisible = value; }
        }

        private bool isVisible = true;

        /// <summary>
        /// 
        /// </summary>
        public bool IsTileViewColumn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int MaximumWidth
        {
            get { return maximumWidth; }
            set { maximumWidth = value; }
        }

        private int maximumWidth = -1;

        /// <summary>
        /// 
        /// </summary>
        public int MinimumWidth
        {
            get { return minimumWidth; }
            set { minimumWidth = value; }
        }

        private int minimumWidth = -1;

        /// <summary>
        /// 
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public HorizontalAlignment TextAlign
        {
            get { return textAlign; }
            set { textAlign = value; }
        }

        private HorizontalAlignment textAlign = HorizontalAlignment.Left;

        /// <summary>
        /// 
        /// </summary>
        public String Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public String ToolTipText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool TriStateCheckBoxes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool UseInitialLetterForGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        private int width = 150;

        #endregion
    }
}