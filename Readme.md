Skyhop.GribParser
=================

The goal of this project is to create a project with which one can easily access the contents of a GRIB2 file from a .NET project. Given the GRIB2 specification covers quite a lot use-cases you're expected to implement a template yourself, if it's not yet available. If you ask nicely a maintainer might help you out if you provide a GRIB file with said templates so that we can run at least a few tests.

## Current state of the project

The following list shows which features have already been implemented, or still need to be implemented. The list with features below is based on the documentation as found [here](https://www.nco.ncep.noaa.gov/pmb/docs/grib2/grib2_doc/).

- [x] Reading from a GRIB2 file
- [x] Reading multiple records from a file
- [x] Section 0 - Indicator Section
	- [x] Table 0.0 - Discipline of Processed Data
- [x] Section 1 - Identification Section
	- [x] Table 1.0 - GRIB Master Tables Version Number
	- [x] Table 1.1 - GRIB Local Tables Version Number
	- [x] Table 1.2 - Significance of Reference Time
	- [x] Table 1.3 - Production Status of Data
	- [x] Table 1.4 - Type of Data
	- [x] Table 1.5 - Identification Template Number
		- [ ] Identification Template 1.0 - Calendar Definition
		- [ ] Identification Template 1.1 - Paleontological Offset
		- [ ] Identification Template 1.2 - Calendar Definition and Paleontological Offset
	- [x] Table 1.6 - Type of Calendar
- [ ] Section 2 - Local Use Section
- [ ] Section 3 - Grid Definition Section
	- [ ] Table 3.0 - Source of Grid Definition
	- [ ] Table 3.1 - Grid Definition Template Number
	- [ ] Table 3.2 - Shape of the Reference System
	- [ ] Table 3.3 - Resolution and Component Flags
	- [ ] Table 3.4 - Scanning Mode
	- [ ] Table 3.5 - Projection Center
	- [ ] Table 3.6 - Spectral Data Representation Type
	- [ ] Table 3.7 - Spectral Data Representation Mode
	- [ ] Table 3.8 - Grid Point Position
	- [ ] Table 3.9 - Numbering Order of Diamonds
	- [ ] Table 3.10 - Scanning Mode for One Diamond
	- [ ] Table 3.11 - Interpretation of List of Numbers at end of section 3
	- [ ] Table 3.15 - Physical Meaning of Vertical Coordinate
	- [ ] Table 3.20 - Type of Horizontal Line
	- [ ] Table 3.21 - Vertical Dimension Coordinate Values Definition
- [ ] Section 4 - Product Definition Section
	- [ ] Table 4.0 - Product Definition Template Number
	- [ ] Table 4.1 - Parameter Category by Product Discipline
	- [ ] Table 4.2 - Parameter Number by Product Discipline and Parameter Category
	- [ ] Table 4.3 - Type of Generating Process
	- [ ] Table 4.4 - Indicator of Unit of Time Range
	- [ ] Table 4.5 - Fixed Surface Types and Units
	- [ ] Table 4.6 - Type of Ensemble Forecast
	- [ ] Table 4.7 - Derived Forecast
	- [ ] Table 4.8 - Clustering Method
	- [ ] Table 4.9 - Probability Type
	- [ ] Table 4.10 - Type of Statistical Processing
	- [ ] Table 4.11 - Type of Time Intervals
	- [ ] Table 4.12 - Operating Mode
	- [ ] Table 4.13 - Quality Control Indicator
	- [ ] Table 4.14 - Clutter Filter Indicator
	- [ ] Table 4.15 - Type of Spatial Processing used to arrive at given data value from the source data
	- [ ] Table 4.16 - Quality Value Associated with Parameter
	- [ ] Table 4.91 - Type of Interval
	- [ ] Table 4.201 - Precipitation Type
	- [ ] Table 4.202 - Precipitable Water Category
	- [ ] Table 4.203 - Cloud Type
	- [ ] Table 4.204 - Thunderstorm Coverage
	- [ ] Table 4.205 - Presence of Aerosol
	- [ ] Table 4.206 - Volcanic Ash
	- [ ] Table 4.207 - Icing
	- [ ] Table 4.208 - Turbulence
	- [ ] Table 4.209 - Planetary Boundary-Layer Regime
	- [ ] Table 4.210 - Contrail Intensity
	- [ ] Table 4.211 - Contrail Engine Type
	- [ ] Table 4.212 - Land Use
	- [ ] Table 4.213 - Soil Type
	- [ ] Table 4.215 - Remotely Sensed Snow Coverage
	- [ ] Table 4.216 - Elevation of Snow Covered Terrain
	- [ ] Table 4.217 - Cloud Mask Type
	- [ ] Table 4.218 - Pixel Scene Type
	- [ ] Table 4.219 - Cloud Top Height Quality Indicator
	- [ ] Table 4.220 - Horizontal Dimension Processed
	- [ ] Table 4.221 - Treatment of Missing Data
	- [ ] Table 4.222 - Categorical Result
	- [ ] Table 4.223 - Fire Detection Indicator
	- [ ] Table 4.224 - Categorical Outlook
	- [ ] Table 4.225 - Weather
	- [ ] Table 4.227 - Icing Scenario (Weather/Cloud Classification)
	- [ ] Table 4.230 - Atmospheric Chemical or Physical Type
	- [ ] Table 4.233 - Aerosol Type
	- [ ] Table 4.234 - Canopy Cover Fraction
	- [ ] Table 4.235 - Wave-Generated Wave Spectral Description
	- [ ] Table 4.236 - Soil Texture Cover Fraction
	- [ ] Table 4.240 - Type of Distribution Function
	- [ ] Table 4.241 - Coverage Attributes
	- [ ] Table 4.242 - Tile Classification
	- [ ] Table 4.243 - Tile Class
	- [ ] Table 4.244 - Quality Indicator
- [ ] Section 5 - Data Representation Section
	- [ ] Table 5.0 - Data Representation Template Number
	- [ ] Table 5.1 - Type of Original Field Values
	- [ ] Table 5.2 - Matrix Coordinate Value Function Definition
	- [ ] Table 5.3 - Matrix Coordinate Parameter
	- [ ] Table 5.4 - Group Splitting Method
	- [ ] Table 5.5 - Missing Value Management for Complex Packing
	- [ ] Table 5.6 - Order of Spatial Differencing
	- [ ] Table 5.7 - Precision of Floating Point Numbers
	- [ ] Table 5.40 - Type of Compression
- [ ] Section 6 - Bit Map Section
	- [ ] Table 6.0 - Bit Map Indicator
- [ ] Section 7 - Data Section
	- [ ] Table 7.0 - Data Template Number
- [ ] Section 8 - End Section


### Templates

**Grid Definition Template**

- [ ] Template 3.0 - Latitude/Longitude
- [ ] Template 3.1 - Rotated Latitude/Longitude
- [ ] Template 3.2 - Stretched Latitude/Longitude
- [ ] Template 3.3 - Rotated and Stretched Latitude/Longitude
- [ ] Template 3.4 - Variable Resolution Latitude/Longitude
- [ ] Template 3.5 - Variable Resolution Rotated Latitude/Longitude
- [ ] Template 3.10 - Mercator
- [ ] Template 3.12 - Transverse Mercator
- [ ] Template 3.13 - Mercator with modelling subdomains definition
- [ ] Template 3.20 - Polar Stereographic Projection
- [ ] Template 3.23 - Polar Stereographic with modelling subdomains definition
- [ ] Template 3.30 - Lambert Conformal
- [ ] Template 3.31 - Albers Equal Area
- [ ] Template 3.33 - Lambert conformal with modelling subdomains definition
- [ ] Template 3.40 - Gaussian Latitude/Longitude
- [ ] Template 3.41 - Rotated Gaussian Latitude/Longitude
- [ ] Template 3.42 - Stretched Gaussian Latitude/Longitude
- [ ] Template 3.43 - Rotated and Stretched Gaussian Latitude/Longitude
- [ ] Template 3.50 - Spherical Harmonic Coefficients
- [ ] Template 3.51 - Rotated Spherical Harmonic Coefficients
- [ ] Template 3.52 - Stretched Spherical Harmonic Coefficients
- [ ] Template 3.53 - Rotated and Stretched Spherical Harmonic Coefficients
- [ ] Template 3.60 - Cubed-Sphere Gnomonic
- [ ] Template 3.61 - Spectral Mercator with modelling subdomains definition
- [ ] Template 3.62 - Spectral Polar Stereographic with modelling subdomains definition
- [ ] Template 3.63 - Spectral Lambert conformal with modelling subdomains definition
- [ ] Template 3.90 - Space View Perspective or Orthographic
- [ ] Template 3.100 - Triangular Grid Based on an Icosahedron
- [ ] Template 3.101 - General Unstructured Grid
- [ ] Template 3.110 - Equatorial Azimuthal Equidistant Projection
- [ ] Template 3.120 - Azimuth-Range Projection
- [ ] Template 3.140 - Lambert Azimuthal Equal Area Projection
- [ ] Template 3.204 - Curvilinear Orthogonal Grids
- [ ] Template 3.1000 - Cross Section Grid with Points Equally Spaced on the Horizontal
- [ ] Template 3.1100 - Hovmoller Diagram with Points Equally Spaced on the Horizontal
- [ ] Template 3.1200 - Time Section Grid
- [ ] Template 3.32768 - Rotated Latitude/Longitude (Arakawa Staggered E-Grid)
- [ ] Template 3.32769 - Rotated Latitude/Longitude (Arakawa Non-E Staggered Grid)

**Product Definition Template**

- [ ] Template 4.0 - Analysis or forecast at a horizontal level or in a horizontal layer at a point in time.
- [ ] Template 4.1 - Individual ensemble forecast, control and perturbed, at a horizontal level or in a horizontal layer at a point in time.
- [ ] Template 4.2 - Derived forecasts based on all ensemble members at a horizontal level or in a horizontal layer at a point in time.
- [ ] Template 4.3 - Derived forecasts based on a cluster of ensemble members over a rectangular area at a horizontal level or in a horizontal layer at a point in time.
- [ ] Template 4.4 - Derived forecasts based on a cluster of ensemble members over a circular area at a horizontal level or in a horizontal layer at a point in time.
- [ ] Template 4.5 - Probability forecasts at a horizontal level or in a horizontal layer at a point in time.
- [ ] Template 4.6 - Percentile forecasts at a horizontal level or in a horizontal layer at a point in time.
- [ ] Template 4.7 - Analysis or forecast error at a horizontal level or in a horizontal layer at a point in time.
- [ ] Template 4.8 - Average, accumulation, extreme values or other statistically processed values at a horizontal level or in a horizontal layer in a continuous or non-continuous time interval.
- [ ] Template 4.9 - Probability forecasts at a horizontal level or in a horizontal layer in a continuous or non-continuous time interval.
- [ ] Template 4.10 - Percentile forecasts at a horizontal level or in a horizontal layer in a continuous or non-continuous time interval.
- [ ] Template 4.11 - Individual ensemble forecast, control and perturbed, at a horizontal level or in a horizontal layer, in a continuous or non-continuous time interval.
- [ ] Template 4.12 - Derived forecasts based on all ensemble members at a horizontal level or in a horizontal layer, in a continuous or non-continuous time interval.
- [ ] Template 4.13 - Derived forecasts based on a cluster of ensemble members over a rectangular area at a horizontal level or in a horizontal layer, in a continuous or non-continuous time interval.
- [ ] Template 4.14 - Derived forecasts based on a cluster of ensemble members over a circular area at a horizontal level or in a horizontal layer, in a continuous or non-continuous time interval.
- [ ] Template 4.15 - Average, accumulation, extreme values or other statistically-processed values over a spatial area at a horizontal level or in a horizontal layer at a point in time.
- [ ] Template 4.20 - Radar product
- [ ] Template 4.30 - Satellite product (Deprecated)
- [ ] Template 4.31 - Satellite product
- [ ] Template 4.32 - Analysis or forecast at a horizontal level or in a horizontal layer at a point in time for simulate (synthetic) satellite data
- [ ] Template 4.33 - Individual Ensemble Forecast, control and perturbed, at a horizontal level or in a horizontal layer at a point in time for simulated (synthetic) satellite data
- [ ] Template 4.34 - Individual Ensemble Forecast, control and perturbed, at a horizontal level or in a horizontal layer, in a continuous or non-continuous interval for simulated (synthetic) satellite data
- [ ] Template 4.35 - Satellite product with or without associated quality values
- [ ] Template 4.40 - Analysis or forecast at a horizontal level or in a horizontal layer at a point in time for atmospheric chemical constituents.
- [ ] Template 4.41 - Individual ensemble forecast, control and perturbed, at a horizontal level or in a horizontal layer at a point in time for atmospheric chemical constituents.
- [ ] Template 4.42 - Average, accumulation, and/or extreme values or other statistically processed values at a horizontal level or in a horizontal layer in a continuous or non-continuous time interval for atmospheric chemical constituents.
- [ ] Template 4.43 - Individual ensemble forecast, control and perturbed, at a horizontal level or in a horizontal layer, in a continuous or non-continuous time interval for atmospheric chemical constituents.
- [ ] Template 4.44 - Analysis or forecast at a horizontal level or in a horizontal layer at a point in time for aerosol.
- [ ] Template 4.45 - Individual ensemble forecast, control and perturbed, at a horizontal level or in a horizontal layer, in a continuous or non-continuous time interval for aerosol.
- [ ] Template 4.46 - Average, accumulation, and/or extreme values or other statistically processed values at a horizontal level or in a horizontal layer in a continuous or non-continuous time interval for aerosol.
- [ ] Template 4.47 - Individual ensemble forecast, control and perturbed, at a horizontal level or in a horizontal layer, in a continuous or non-continuous time interval for aerosol.
- [ ] Template 4.48 - Analysis or forecast at a horizontal level or in a horizontal layer at a point in time for aerosol.
- [ ] Template 4.49 - Individual ensemble forecast, control and perturbed, at a horizontal level or in a horizontal layer at a point in time for optical properties of aerosol.
- [ ] Template 4.51 - Categorical forecast at a horizontal level or in a horizontal layer at a point in time.
- [ ] Template 4.53 - Partitioned parameters at a horizontal level or horizontal layer at a point in time.
- [ ] Template 4.54 - Individual ensemble forecast, control and perturbed, at a horizontal level or in a horizontal layer at a point in time for partitioned parameters.
- [ ] Template 4.55 - Spatio-temporal changing tiles at a horizontal level or horizontal layer at a point in time
- [ ] Template 4.56 - Individual ensemble forecast, control and perturbed, at a horizontal level or in a horizontal layer at a point in time for spatio-temporal changing tile parameters.
- [ ] Template 4.57 - Analysis or forecast at a horizontal level or in a horizontal layer at a point in time for atmospheric chemical constituents based on a distribution function
- [ ] Template 4.58 - Individual Ensemble Forecast, Control and Perturbed, at a horizontal level or in a horizontal layer at a point in time interval for Atmospheric Chemical Constituents based on a distribution function
- [ ] Template 4.59 - Individual ensemble forecast, control and perturbed, at a horizontal level or in a horizontal layer at a point in time for spatio-temporal changing tile parameters (corrected version of template 4.56)
- [ ] Template 4.60 - Individual Ensemble Reforecast, control and perturbed, at a horizontal level or in a horizontal layer at a point in time.
- [ ] Template 4.61 - Individual Ensemble Reforecast, control and perturbed, at a horizontal level or in a horizontal layer, in a continuous or non-continuous time interval 
- [ ] Template 4.62 - Average, Accumulation and/or Extreme values or other Statistically-processed values at a horizontal level or in a horizontal layer in a continuous or non-continuous time interval for spatio-temporal changing tiles at a horizontal level or horizontal layer at a point in time
- [ ] Template 4.63 - Individual ensemble forecast, control and perturbed, at a horizontal level or in a horizontal layer in a continuous or non-continuous time interval for spatio-temporal changing tiles
- [ ] Template 4.67 - Average, accumulation and/or extreme values or other statistically processed values at a horizontal level or in a horizontal layer in a continuous or non-continuous time interval for atmospheric chemical constituents based on a distribution function
- [ ] Template 4.68 - Individual ensemble forecast, control and perturbed, at a horizontal level or in a horizontal layer in a continuous or non-continuous time interval for atmospheric chemical constituents based on a distribution function.
- [ ] Template 4.70 - Post-processing analysis or forecast at a horizontal level or in a horizontal layer at a point in time.
- [ ] Template 4.71 - Post-processing individual ensemble forecast, control and perturbed, at a horizontal level or in a horizontal layer at a point in time.
- [ ] Template 4.72 - Post-processing average, accumulation, extreme values or other statistically processed values at a horizontal level or in a horizontal layer in a continuous or non-continuous time interval.
- [ ] Template 4.73 - Post-processing individual ensemble forecast, control and perturbed, at a horizontal level or in a horizontal layer, in a continuous or non-continuous time interval.
- [ ] Template 4.91 - Categorical forecast at a horizontal level or in a horizontal layer in a continuous or non-continuous time interval.
- [ ] Template 4.254 - CCITT IA5 character string
- [ ] Template 4.1000 - Cross-section of analysis and forecast at a point in time.
- [ ] Template 4.1001 - Cross-section of averaged or otherwise statistically processed analysis or forecast over a range of time.
- [ ] Template 4.1002 - Cross-section of analysis and forecast, averaged or otherwise statistically-processed over latitude or longitude.
- [ ] Template 4.1100 - Hovmoller-type grid with no averaging or other statistical processing
- [ ] Template 4.1101 - Hovmoller-type grid with averaging or other statistical processing


**Data Representation Template**

- [ ] Template 5.0 - Grid Point Data - Simple Packing
- [ ] Template 5.1 - Matrix Value at Grid Point - Simple Packing
- [ ] Template 5.2 - Grid Point Data - Complex Packing
- [ ] Template 5.3 - Grid Point Data - Complex Packing and Spatial Differencing
- [ ] Template 5.4 - Grid Point Data - IEEE Floating Point Data
- [ ] Template 5.40 - Grid Point Data - JPEG2000 Compression
- [ ] Template 5.41 - Grid Point Data - PNG Copmression
- [ ] Template 5.50 - Spectral Data - Simple Packing
- [ ] Template 5.51 - Spectral Data - Complex Packing
- [ ] Template 5.61 - Grid Point Data - Simple Packing With Logarithm Pre-processing
- [ ] Template 5.200 - Run Length Packing With Level Values

**Data Template**

- [ ] Template 7.0 - Grid Point Data - Simple Packing
- [ ] Template 7.1 - Matrix Value at Grid Point - Simple Packing
- [ ] Template 7.2 - Grid Point Data - Complex Packing
- [ ] Template 7.3 - Grid Point Data - Complex Packing and Spatial Differencing
- [ ] Template 7.4 - Grid Point Data - IEEE Floating Point Data
- [ ] Template 7.40 - Grid Point Data - JPEG2000 Compression
- [ ] Template 7.41 - Grid Point Data - Portable Network Graphics (PNG) format
- [ ] Template 7.50 - Spectral Data - Simple Packing
- [ ] Template 7.51 - Spectral Data - Complex Packing