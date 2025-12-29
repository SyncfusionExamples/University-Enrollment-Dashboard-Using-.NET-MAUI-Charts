# Student Enrollment Dashboard Using .NET MAUI Charts

A dashboard is a centralized interface that brings together multiple visualizations to provide insights at a glance. It helps users monitor key metrics, identify trends, and make informed decisions quickly. Dashboards are especially useful in scenarios like admissions, HR, or wellness tracking, where diverse data points need to be understood in context.

## Cartesian Chart
The SfCartesianChart is used to plot data along X and Y axes, making it ideal for comparisons across categories.

**Key Features**
- Supports multiple series types such as column, line, and bar for flexible visualization.
- Interactive zooming and panning for exploring large datasets in detail.
- Data binding support to map values directly from collections.
- Ability to render multiple series simultaneously for comparison.
- Customization options for axes, labels, legends, and series styling.

## Circular Chart
The SfCircularChart is designed for proportion‑based visualization, such as pie and doughnut charts.

**Key Features**
- Supports pie and doughnut series for clear representation of parts‑to‑whole data.
- User interactions like tooltips, selection, and explode effects enhance readability.
- Legends provide additional context about categories and values.
- Dynamic updates reflect live data changes instantly.
- Compact design suitable for dashboards and mobile layouts.

## Sunburst Chart
The SfSunburstChart is ideal for visualizing hierarchical data in concentric rings.

**Key Features**
- Displays hierarchical relationships across multiple levels (e.g., degree → course → program type).
- Data labels improve readability of segments.
- Legends help identify categories quickly.
- Tooltips provide additional details on hover.
- Custom palette brushes allow thematic styling.

## What We Did in This Sample
In this sample, we built a Student Enrollment Dashboard using Syncfusion .NET MAUI Toolkit Charts. The dashboard visualizes:

- Admission capacity with a radial gauge.
- Urgency and deadlines with a notice banner.
- Diversity with a semi‑doughnut chart.
- Program distribution with a sunburst chart.
- Global reach with a column chart.
  
Together, these tiles tell the complete story of enrollment health, empowering universities to make smarter and faster decisions.

## Output
![Presentation1 (1)](https://github.com/user-attachments/assets/67a30561-fe57-423e-b28f-dca036dde24c)

## Troubleshooting
### Path Too Long Exception  
If you encounter this when building, close Visual Studio and rename the repository to a shorter path, then rebuild.
