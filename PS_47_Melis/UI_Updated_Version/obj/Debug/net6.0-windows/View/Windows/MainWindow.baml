   M S B A M L   `   `   `  ����M  IUI_Updated_Version, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:UI_Updated_Version.ViewModelUI_Updated_Version.ViewModel  5   	   #    UI_Updated_Version.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9vm*clr-namespace:UI_Updated_Version.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	      6   0UI_Updated_Version.ViewModel.MainWindowViewModel  5
   
   .��5      � $��-93,-20,0,-87q�6    J� RenderTransformOrigin$ 0.498,0.317&�6"    � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6    � RowDefinitions 5   
   �� 5      $
��421* �6   �� 5      $
��120* �6   .+�5   
   �� -   5        $��btnGoToUserInformation��5   ,   $��User information��6   $
��Left=�6o   $	��Top=�6�   $��48��6�   $	��118��6�   $��
446,54,0,0q�6�   $ -0.064,0.45&�6�   �� 5   
   -   5        $��
btnAddUser��5   $   $��Add user��6   $
��Left=�6O   $	��Top=�6j   $��55��6�   $	��116��6�   $��448,166,0,0q�6�   �� 5   
   -   5        $��	btnRemove��5   "   $��Remove��6   $
��Left=�6K   $	��Top=�6f   $��54��6~   $	��118��6�   $��446,107,0,0q�6�   $ 
2.37,0.324&�6�   �� 5   
   -   5        $��btnLogs��5       $
��Logs��6   $
��Left=�6E   $	��Top=�6`   $��45��6x   $	��118��6�   $��447,226,0,0q�6�   5       5!      