   M S B A M L   `   `   `  ����M  IUI_Updated_Version, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:UI_Updated_Version.ViewModelUI_Updated_Version.ViewModel  5   	   0    *UI_Updated_Version.View.Windows.LogsWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9vm*clr-namespace:UI_Updated_Version.ViewModel     5   	     � Title$  
LogsWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	      2   ,UI_Updated_Version.ViewModel.LoggerViewModel  5
   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��331* �6   �� 5      $	��69* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��loggs��5         AutoGenerateColumns$ False��6@   $��2��6\   ��6    �� *	Loggers+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      
IsReadOnly$
 True��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $	 Log��6%   $
 True��62      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6`    6D   �� *	Message+6`   5      �� 5   
   -   5        $��btnBackToMain��5   5   $��Back to Main��6   $��1��6(   $
��Left=�6f   $��Bottom=�6�   $��42��6�   $	��100��6�   $��	334,0,0,0q�6�   5      5      