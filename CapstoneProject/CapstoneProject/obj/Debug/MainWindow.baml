   M S B A M L   `   `   `  ����J  FCapstoneProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CapstoneProjectCapstoneProject  5   	        CapstoneProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CapstoneProject     5   	   -   5          �Name$  frmMain��5   	    � Title$ 
PERT Chart��5   	   $	��450��6   $	��800��6)   4  .System.Windows.Automation.AutomationProperties   Name$ winMain��65   .��5
      � .+�5   
   o� $��Stretch=�6   $��20��6-   $	��Top=�69   $��0q�6Q   .@�5      m� $
��File��6   $��20��6%   $
��auto��61   .@�5      m� -   5         m�Name$ mi_newProject��5      $��New Project��62   $��20��6G   $
��Left=�6S   $
��auto��6n   6|   m� 5      -   5        $ mi_openProject��5      $��Open Project��63   $
��Left=�6I   $��20��6d   $
��auto��6p   6}   m� 5      -   5        $ mi_saveProject��5      $��Save Project��63   $
��Left=�6I   $��20��6d   $
��auto��6p   �� 5      m� 5      -   5        $ mi_projectProperties��5      $��Project Properties��69   $
��Left=�6U   $��20��6p   $
��auto��6|   6�   �� 5      m� 5      -   5        $ mi_exit��5      $
��Exit��6,   $
��Left=�6:   $��20��6U   $
��auto��6a   6n   5      m� 5      $
��View��6   $��20��6%   $
��auto��61   .@�5      m� -   5        $ 
mi_showMin��5      $��Show Min. Estimates��6/   $
��Left=�6L   $��20��6g   $
��auto��6s   m� 5      -   5        $ 
mi_showMax��5      $��Show Max. Estimates��6/   $
��Left=�6L   $��20��6g   $
��auto��6s   m� 5      -	   5        $ mi_showMostLikely��5      $��Show Most Likely��66   $
��Left=�6P   $��20��6k   $
��auto��6w   5      m� 5      -
   5        $ mi_help��5      $
��Help��6(   $��20��66   $
��auto��6B   5       �� 5"   
   -   5         ��Name$ 	secCanvas��5"      $��10,20,10,10q�6$   $	��800��69   $	��400��6E   5$       � 5'   
   -   5          �Name$ 	frameMain��5'      $��0,20,0,0q�6#     � NavigationUIVisibility$ Hidden=�65   �� 5(   
   -   5        $��Button��5(      $
��Left=�6"   $��317,181,0,0q�6=   $	��Top=�6R   $��75��6j   6u   5*      5+      