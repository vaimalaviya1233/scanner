﻿using System.ComponentModel.DataAnnotations;
using Windows.Devices.Scanners;
using static Enums;

namespace Scanner.Models
{
    public class ScanResolution
    {
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // DECLARATIONS /////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "ImageScannerResolution is required")]
        public ImageScannerResolution ImageScannerResolution;

        [Required(ErrorMessage = "Annotation is required")]
        public ResolutionAnnotation Annotation;


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // CONSTRUCTORS / FACTORIES /////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public ScanResolution()
        {

        }
    }

    /// <summary>
    ///     The possible properties a resolution value can have.
    /// </summary>
    public enum ResolutionAnnotation
    {
        None = 0,
        Default = 1,
        Documents = 2,
        Photos = 3,
    }
}
