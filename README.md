# robocopygui
Robocopy, or Robust File Copy, is a command line directory replication tool from Microsoft. It has the same abilities as more familiar commands such as copy and xcopy, the biggest difference is that its not a file copier, it was made to copy folders and keep them in the same form as they were.

Source : https://www.windows-commandline.com/robocopy-command-syntax-examples/

Copy a directory
Example: Copy all the files in the directory D:\dir1\data to E:\backup\data. Don’t include sub directories or the files stored in those.

Robocopy  D:\dir1\data E:\backup\data
The above command copies system files and hidden files too. Copy and Xcopy commands skip these files by default.
At the end of the command execution, it would print the summary like below.

          Total    Copied   Skipped  Mismatch    FAILED    Extras
    Dirs :        22        22         0         0         0         0
   Files :       113       113         0         0         0         0
   Bytes :   42.96 m   42.96 m         0         0         0         0
   Times :   0:00:01   0:00:00                       0:00:00   0:00:00

   Speed :            83744483 Bytes/sec.
   Speed :            4791.897 MegaBytes/min.
   Ended : Wed Oct 22 22:26:14 2014
Copy directory structure
Run the below Robocopy command to copy directory structure i.e deep copy of folder hierarchy and the data in all the subfolders.

Robocopy /S D:\dir1\data E:\backup\data
This command does not copy empty directories. To copy them, you need to add /E switch.

Robocopy /S /E  D:\dir1\data E:\backup\data
Delete files and directories from the source after copying
You can add /MOV switch to delete files and /MOVE switch to delete both files and directories.

For deleting files:

Robocopy /MOV /S /E  D:\dir1\data E:\backup\data
For deleting files and directories:

Robocopy /MOVE /S /E  D:\dir1\data E:\backup\data
Modify file attributes for the copied files
Using robocopy command we can also change attributes(system, hidden, readonly) of the copied files. This affects the attributes of the files in the new location, it does not impact the files in the source directory.

For example to copy all files from one directory to another directory and also set hidden attribute for all the files you can trigger ‘Robocopy’ with the below syntax.

Robocopy /S /E  /A+:H D:\dir1\data E:\backup\data
Mirror copy a directory
Below Robocopy command creates a replica of the source folder in the specified destination folder

Robocopy /MIR sourceFolder  destinationFolder
This command also deletes any extra files that are present in the destination and are not present in source.
