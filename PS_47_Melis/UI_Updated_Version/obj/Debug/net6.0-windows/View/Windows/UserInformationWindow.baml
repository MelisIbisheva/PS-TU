   M S B A M L   `   `   `  ����M  IUI_Updated_Version, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:UI_Updated_Version.View.WindowsUI_Updated_Version.View.Windows  5   	   K*clr-namespace:UI_Updated_Version.ViewModelUI_Updated_Version.ViewModel  5   	   ;    5UI_Updated_Version.View.Windows.UserInformationWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:UI_Updated_Version.View.Windows     5   	   9vm*clr-namespace:UI_Updated_Version.ViewModel     5   	     � Title$  UserInformationWindow��5	   	   $	��450��6'   $	��800��64    � DataContext 5      0   *UI_Updated_Version.ViewModel.UserViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��students��5      $��0��6#      AutoGenerateColumns$ False��6N   ��60   �� *Users+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      
IsReadOnly$
 True��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $
 Name��6%   $
 True��63    6E   �� *Name+  5      $
 Role��6%   $
 True��63    6E   �� *Role+  5      $ Email��6%   $
 True��64    6F   �� *Email+  5      $ Faculty number��6%   $
 True��6=    6O   �� *	FNumber+  5      $ Expires��6%   $
 True��66    6H   �� *	Expires+  5      -   5        Password��$ Password��5   7   $
 True��6I    6[   �� *
Password+5      d� 5    
   -   5         d�Name$ togglePasswordButton��5       $��0��65   $��Show Password��6B   $
��Left=�6}   $��Bottom=�6�   $��42��6�   $	��100��6�   $��	334,0,0,0q�6�   �� 5"   
   -   5        $��btnBackToMain��5"   5   $��Back to Main��6   $��1��6(   $
��Left=�6f   $��Bottom=�6�   $��42��6�   $	��100��6�   $��	334,0,0,0q�6�   5#      5$      