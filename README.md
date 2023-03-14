# PLC-Tag-Manager

The Tag Master 5000 is a state of the art PLC tag managing application, designed to make the life of an AGR control systems individual just a little bit easier. With the ability to read and write just about any tag in the PLC (including user-defined type), gone are the days of needing an active -insert overpriced PLC software company here- software license to make minor edits to your systems man informational tags!

---

## KNOWN ISSUES & EXPECTED UPDATES
### BUGS
+ Currently, the tag read function cannot read a UDT with a nested array (an array within the member list of the UDT itself). This is being looked into for a future update, but may take some time.
+ .CSV export sees first comma in tag name as delimiter for multidimensional arrays - 'Alarm_Message[0,0]'. Shifts each column one to the right.

### PLANNED
+ A search function will be added to the Tag List screen to allow filtering of the tag list based on name. (In Progress)
+ Import existing excel file to download to tags.
+ Change read functions to asynchronous to prevent application from freezing up when reading large tags.

---

## OPERATION

### IP ADDRESS SETUP

To set the connection parameters for communication with the target CPU, you will need the following information:

**[IPv4 Address]** -    Any 4-octet address will work. This is entered in the format XXX.XXX.XXX.XXX, where XXX is any number between 0-255. The indicator next to this field will let you know if the address you entered points to a network device.

+ **Note** - This will not tell you if the device you are targeting is the processor you wish to target. It will only inform you that it has found a device on your network with that address.
                  
**[CPU Rack #]** -      This is the current rack number given to your CPU at the above-entered address, typically 1.

**[CPU Slot #]** -      This is the slot location of the CPU on the backplane, typically 0.

**[Controller Type]** - The type of CPU you will be communicating with. Currently supported models are: 
+ ControlLogix (also supports CompactLogix and GuardLogix)
+ PLC5
+ SLC500
+ LogixPCCC
+ Micro800
+ MicroLogix
+ Omron
                                                                                                  
<b>[Comm Protocol]</b> -   The protocol your PC will use to communicate with the target CPU. Currently supported protocols are:
+ Allen-Bradley Ethernet/IP
+ Modbus TCP
                                                                                                                        
<b>[Set Default Comm Settings]</b> - Press this button to set all of the current IP configuration field values as default. This will save these entered values for the next time the application is launched.

<b>[Restore Default Comm Settings]</b> - Press this button to restore your previously saved IP configuration into the appropriate fields.

### TAG READING

All you need is a valid tag name to begin reading tags! Enter a known tag name into the <b>[Tag Name]</b> field and press <b>[Read Tags]</b> to populate your window with the tag data.

If you're unsure of the exact spelling for the tag you wish to read, follow these steps:
1. Select <b>[Tools]</b> from the toolbar.
2. Click on <b>[View Tag List]</b>. A new window will appear with a complete list of tags in your target processor.
3. Highlight the tag you wish to read from the list and either double-click it or click <b>[Select Tag]</b> at the bottom of the window.
4. The <b>[Tag Name]</b> field is now autopopulated with your selected tag's name.
5. Click the <b>[Read Tags]</b> button!

+ **Note** - For large tags, such as alarm and info messages, the tag data window may take a few minutes to populate. It may appear that the program has frozen, but it is just buffering all of the incoming data before being displayed.

**[Set Default Tag]** - Press this button to save the current tag name as your default tag name. This will autopopulate the saved name the next time you launch the application.

### TAG WRITING

After your tag data has populated, all you have to do is select the field you wish to edit and make your change. The fields will highlight yellow to indicate that a change has been made.

Once you've made all of your changes, click the **[Write Changes]** button at the bottom of the application. All of your changes will be written to the appropriate tags in your target processor!

Should you wish to cancel your pending changes, simply click the **[Cancel Changes]** button next to the tag data window. This will undo every change you have not already written to your processor, so make sure you wish to delete all of your changes!

### EXPORTING

The Tag Master 5000 allows for the export of the currently populated tag data, including all tag names and headers, in two convenient formats:
+ Excel (.xlsx)
+ Comma-Separated Values (.csv)

To export your data, all you must do is:
1. Select **[FILE]** from the toolbar.
2. Select **[Export to...]** from the drop-down menu.
3. Click on the format you wish to export to.

---

## THE END(?)

That's it! Those are all of the features for now. Feel free to leave any bug reports, feature requests, or questions in the Issues tab here on Git and I will do my best to take care of them in a timely manner.



















