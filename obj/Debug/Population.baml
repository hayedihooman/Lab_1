   M S B A M L   `   `   `  ����@  <Lab_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab_1Lab_1  5   	       Lab_1.Population   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Lab_1     5   	     � Title$  
Population��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      $
��109* �6   �� 5      $	��72* �6   �� 5      $
��273* �6   �� 5      $
��346* �6   .+�5   
   �� -   5         ��Name$ Population_lbl��5      $��
Population��6(   $��	20,52,1,0q�6=   $	��Top=�6P   $��1��6h   $��26��6x   �� 5   
   -   5        $ Avg_Lbl��5      $��Average��6!   $
��Left=�63   $��
20,113,0,0q�6N   $	��Top=�6b   $��1��6z   $��26��6�   $��53��6�   �� 5   
   -   5        $ NumOfDays_lbl��5      $��Number of days��6'   $
��Left=�6@   $��
20,181,0,0q�6[   $	��Top=�6o    J� RenderTransformOrigin$ -1.279,0.209&�6�   $��1��6�   $��26��6�   $��95��6�   $��2��6�   �� 5   
   -   5         ��Name$ 
ppt_TxtBox��5      $
��Left=�6&   $��	62,52,0,0q�6A    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��120��6�   $��3��6�   $��18��6�   �� 5   
   -   5        $ 
AvgTxt_Box��5      $
��Left=�6&   $��
62,108,0,0q�6A   $
 Wrap=�6U   $	��Top=�6i   $	��120��6�   $��3��6�   $��18��6�   �� 5   
   -   5        $ NumOfDays_TxtBox��5      $
��Left=�6,   $��
62,181,0,0q�6G   $
 Wrap=�6[   $	��Top=�6o   $	��120��6�   $��3��6�   $��18��6�   �� 5   
   -   5         ��Name$ Calc_Btn��5      $��	Calculate��6#   $
��Left=�67   $��
20,271,0,0q�6R   $	��Top=�6f   $��1��6~   $��20��6�   $��52��6�   �� 5   
   -   5        $ 
return_Btn��5      $��Return��6%   $
��Left=�66   $��
62,271,0,0q�6Q   $	��Top=�6e   $��3��6}   $��20��6�   $��39��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ dataGrid��5      $��35,34,81,92q�6%      AutoGenerateColumns .  $��4��6V   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$	
 Day��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Day+  5      $
 
Population��6%    69   �� *
Population+5      5      5       