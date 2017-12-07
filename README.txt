Timothy Hayduk - 3D Map Layout, Chemical bar graph (Converted to Pie Chart), multi-chart comparisons, Parallel Coordinate Graph, Data conversion.
Willis Fulmer - Interaction, VR Integration, 3D state conversion, filtering algorithm, Parallel Coordinate Graph, Controller integration.
Jesse Pinkston - Industry Sector bar graph (Unimplemented, converting to pie chart)

For our Device Starter, we decided to stick with the same data set from our Data Starter, 
which was the EPA Releases set.

We decided to use VR to create our visualization, using Unity to create a 3D map of the 50 United States. 
This map was raised and colored based on the amount of releases in each state. The states were created by
taking an image of the outline of each state and filling it in with a solid color. Then a .STL file was
created using the webapp http://app.selva3d.com. Each of these files were then converted to .obj files using this website http://www.greentoken.de/onlineconv/. Note: this process is only useful for extruding a 2D image to create a 3D object.

For interaction, we have allowed the user to look at and click on a state. This will bring up a pie chart
to the left of the states with the top 10 chemicals released in that state. You can select up to three 
states to generate pie charts for comparison. Clicking on a selected state will deselect it and clear 
it's chart.

These pie charts allow the user to look at any wedge to disply the name of the corresponding chemical.
This will also highlight that chemical on any other pie charts, if it exists, for comparison.

You can also use the arrow keys to change which year of data you're viewing. Currently we've included
data for the years 2009-2015. There is a slider located below the US map indicating the current year.

There are several Python scripts included in this repo used to manipulate the data. These scripts expect
a json file as their input, which we used an online csv-to-json converter to create.
 - Online converter: http://www.convertcsv.com/csv-to-json.htm
 - StateHeights.py will generate a new json file containing the scaled height for each state
 - StateChemicals.py will generate a new json file containing the top 10 chemical names and values for 
   each state.
 - StatePercentages.py will calculate the percentage of the total releases for each of the boolean values in 
   the dataset for each state. (FEDERAL_FACILITY, METAL, CLEAR_AIR_ACT_CHEMICAL, CARCINOGEN)
NOTE: If using our data files, the CSV to JSON converter that we used added some strange, hidden characters
  at the beginning of the files. There are lines at the top of the Python scripts to remove them.
  
WARNING: There is a bit of an issue with the pie chart interaction when using the Oculus Rift. It appears
the cursor is being offset when using the headset, so be aware that the colliders for the pie chart wedges
will not work correctly until we can track down this bug.