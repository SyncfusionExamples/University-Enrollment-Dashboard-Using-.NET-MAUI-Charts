# Student Enrollment Dashboard Using .NET MAUI Toolkit Charts

This sample demonstrates a modern, responsive Student Enrollment Dashboard built with .NET MAUI and Syncfusion® .NET MAUI Toolkit Charts. It visualizes key academic metrics such as admissions, vacancies, diversity, program distribution, and regional reach, helping universities make data‑driven enrollment decisions.

## Syncfusion .NET MAUI Charts
A high‑performance charting library for .NET MAUI apps with:
- Broad chart coverage: Radial gauge, column, doughnut, sunburst, and more.
- Interactivity: Tooltips, data labels, selection, animations.
- Styling: Flexible APIs for axes, legends, labels, palettes, and annotations.

Getting started: https://help.syncfusion.com/maui/cartesian-charts/getting-started

## Student Enrollment Dashboard
### Layout overview
**Three‑row responsive layout:**
- Title bar: University name with degree filter.
- Middle row: Admission gauge, notice banner, gender distribution chart.
- Bottom row: Program distribution (Sunburst) and Students by Country/Region chart.

**Responsive behavior:**
- Desktop: Degree filter placed beside the title; charts arranged side by side.
- Mobile: Degree filter moves below the title; charts stack vertically for readability.

## Dashboard Components
### Admission Count Details (Radial Gauge)
- **Chart Used: SfRadialGauge**
- **Why we used it**: A radial gauge is ideal for showing admitted seats versus total capacity. It feels like a KPI meter, making progress instantly clear to admissions teams.

**Key Features**
- Axes: Circular arc axis with customizable labels, ticks, and lines.
- Ranges: Visual ranges highlight where values fall on the scale.
- Pointers: Multiple pointer types (needle, shape, content, range) to indicate values.
- Pointer animation: Smooth transitions when values change.
- Pointer interaction: Drag pointers at runtime to adjust values dynamically.
- Annotations: Add text or images at points of interest for clarity.

### Gender Distribution (Semi‑Doughnut Chart)
- **Chart Used: SfCircularChart → DoughnutSeries**
- **Why we used it**: Diversity is a critical enrollment metric. A semi‑doughnut chart reduces visual weight while clearly showing proportions across Female, Male, and Other categories.

**Key Features**
- Chart types: Supports pie and doughnut series for flexible visualization.
- User interaction: Tooltips, selection, and explode effects enhance exploration.
- Legends: Provide additional context about categories and values.
- Dynamic update: Reflects live data changes instantly when switching degrees.

### Program Distribution (Sunburst Chart)
- **Chart Used: SfSunburstChart**
- **Why we used it**: Universities need to see the bigger picture of enrollment across degrees, courses, and program types. A sunburst chart turns hierarchical data into an interactive circular view.

**Key Features**
- Data visualization: Represents hierarchical data across multiple levels.
- Data labels: Improve readability of segments.
- Legend: Helps identify categories at a glance.
- Tooltip: Displays additional details on hover.
- Customization: Palette brushes allow thematic styling.
- Center view: Elevation option to display extra information in the middle.

### Students by Country/Region (Column Chart)
- **Chart Used: SfCartesianChart → ColumnSeries**
- **Why we used it:** To highlight global diversity, a column chart makes it easy to compare enrollment counts across countries. The height of each column reflects student numbers, making differences instantly visible.

**Key Features**
- Series variety: Supports multiple series types for flexible visualization.
- Data binding: Maps data directly from specified paths.
- Interactive zooming: Explore portions of large datasets in detail.
- Multiple series rendering: Compare and visualize different datasets simultaneously.
- Customization: Options for axes, labels, legends, and series styling.

### MVVM and Data Binding
Pattern: MVVM with observable collections for charts and tiles.
ViewModel drives:
- Degree filter (SelectedDegree)
- Admission metrics (TotalSeats, AdmittedSeats)
- Vacancy and deadline data
- Gender statistics (Category/Count)
- Program distribution (Degree → Course → ProgramType)
- Country statistics (Country/Count)

## Output
<img width="975" height="484" alt="image" src="https://github.com/user-attachments/assets/75a6ccac-8337-4c87-abc1-6e93bbd16f8f" />

## Troubleshooting
### Path Too Long Exception  
If you encounter this when building, close Visual Studio and rename the repository to a shorter path, then rebuild.
