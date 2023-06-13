# FastDragBlazor
A fast draggable list implementation for Blazor, used in Valour

# What is it?
SortableJS is amazing but the performance simply did not scale for Valour's (very large) channel lists. To remedy this, I used relative positioning and a linear data flow to create an incredibly performant drag-and-drop system which has smooth animations and some neat features.

Most notably, there is zero javascript in this project. Every event is handled through Blazor bindings.

You should note that this package is being created specifically for use in Valour. It's open source for your enjoyment, but support and documentation is not a major focus. There is a example in the project if you are curious how to put it together.

# Contributions
You can contribute whatever you wish - just keep in mind that if your changes break functionality required for Valour, they probably will not be pulled in. Optmizations are very welcome.
