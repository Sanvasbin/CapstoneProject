   M S B A M L   `   `   `  ����J  FCapstoneProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CapstoneProjectCapstoneProject  5   	   #    CapstoneProject.frmCreateTask   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CapstoneProject     5   	     � Title$  Create Task��5	   	   $	��400��6   $	��265��6*   .��5
      � $��0,0,2,0q�6   .+�5   
   �� -   5         ��Name$ lblTaskName��5      $��
Task Name:��6%   $
��Left=�6:   $��	10,10,0,0q�6U   $	��Top=�6h   �� 5   
   -   5         ��Name$ tbxTaskName��5      $
��Left=�6'   $��23��6B   $��
113,13,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $ lblMinDuration��5      $��Min Duration:��6(   $
��Left=�6@   $��
10,130,0,0q�6[   $	��Top=�6o   �� 5   
   -   5        $ tbxMinDuration��5      $
��Left=�6N   $��23��6i   $��113,133,0,0q�6u   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ lblMaxDuration��5      $��Max Duration:��6(   $
��Left=�6@   $��
10,158,0,0q�6[   $	��Top=�6o   �� 5   
   -   5        $ tbxMaxDuration��5      $
��Left=�6N   $��23��6i   $��113,161,0,0q�6u   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ lblTaskDescription��5      $��Task Description:��6,   $
��Left=�6H   $��	10,41,0,0q�6c   $	��Top=�6v   �� 5   
   -   5        $ tbxTaskDescription��5      $
��Left=�6.   $��87��6I   $��
113,41,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5   
   -	   5        $ lblOwner��5      $��Owner:��6"   $
��Left=�63   $��
10,212,0,0q�6N   $	��Top=�6b   �� 5   
   -
   5         ��Name$ cmbOwner��5      $
��Left=�6%   $��113,216,0,0q�6@   $	��Top=�6U   $	��120��6m   5      �� 5   
   -   5        $ lblPriorityLevel��5      $��Priority Level:��6*   $
��Left=�6D   $��
10,185,0,0q�6_   $	��Top=�6s   �� 5   
   -   5        $ cmbPriority��5      $
��Left=�6(   $��113,189,0,0q�6C   $	��Top=�6X   $	��120��6p   .@�5      �� .��6   16   �� 5      .��6   26   �� 5       .��6   36   �� 5!      .��6   46   �� 5"      .��6   56   5#      �� 5$   
   -   5        $ 	lblStatus��5$      $��Status:��6#   $
��Left=�65   $��
10,239,0,0q�6P   $	��Top=�6d   �� 5&   
   -   5        $ 	cmbStatus��5&      $
��Left=�6&   $��113,243,0,0q�6A   $	��Top=�6V   $	��120��6n   .@�5'      �� .��6   Not Started6(   �� 5(      .��6   In Progress6(   �� 5)      .��6   	Completed6&   5*      �� 5+   
   -   5         ��Name$ btnSubmitAndClose��5+      $��Submit and Close��6,   $
��Left=�6G   $	��Top=�6b   $	��223��6z   $��
10,300,0,0q�6�   $��22��6�   6�   �� 5,   
   -   5        $ btnSubmitAndContinue��5,      $��Submit and Continue��6/   $
��Left=�6M   $	��Top=�6h   $	��223��6�   $��
10,327,0,0q�6�   $��22��6�   6�   5-      5.      