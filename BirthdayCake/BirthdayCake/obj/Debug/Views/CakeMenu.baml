   M S B A M L   `   `   `  ����G  CBirthdayCake, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:BirthdayCake.ViewsBirthdayCake.Views  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   !    BirthdayCake.Views.CakeMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:BirthdayCake.Views     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   3system&clr-namespace:System;assembly=mscorlib  5   	   -   5          � Title$  Mistico Plus��5
   	   $	��200��5   	   $	��700��5   	   $	��700��5   	   $
��1000��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   �� 5      $��40 �6    � ColumnDefinitions 5   
   �� 5      $��1 �6   �� 5      $��* �6   .+�5   
   '  !MaterialDesignThemes.Wpf.Snackbar  -   5          Name$ SnackBarIzmeni��5   "   $��0��5   "   $��2��5   "      IsActive .  ���	#FF8BC34A$	��Top=�5!   "   $��5q�5"   "   $��16(�5#   "   $��Center=�5$   "      Message. 5%      .  (MaterialDesignThemes.Wpf.SnackbarMessage  $.��(Uspešno ste napravili izmene u profilu!��6-   $��Center=�5&   -   
���   �   ActionCommand 5(   -   �� *Profil_Click+5)        5*   
   -   5        $ SnackBarIzmeniGazdinstvo��5-   "   $��0��5*   "   $��2��5+   "    .  ���	#FF8BC34A$	��Top=�5/   "   $��5q�50   "   $��16(�51   "   $��Center=�52   "   . 53        $9��3Uspešno ste napravili izmene u kartici gazdinstvo!��6-   $��Center=�54   -   
���   � 56   -   �� *Gazdinstvo_Click+57      �� 58   
   $��0��6   $��1��59      $��2��5:      $��0q�5;      $��0,70,0,0q�5<      $��5��5=      	 K� ZIndex$	 1��5>      
��� ���
 �� CornerRadius$
 0��5@      $��Stretch=�5A      $	��Top=�5B      6+   �� 5C   
   $��0��6   $��1��5D      $��0q�5E      $��0,0,0,-5q�5F      $��10��5G      
��� ���$
 0��5I      $��Stretch=�5J      $��Bottom=�5K      6.   (  "MaterialDesignThemes.Wpf.ColorZone  5L   
      Mode$ 
PrimaryMid=�6#   $��1��5M   #   $	��top=�5N   #   $��Right=�5O   #   $
��1022��5Q   #   ��5P   #   Z� .��5R      � $��0,0,0,0q�6   .+�5S      � $��Center=�6   $��Right=�5T       5U      �� 5V      $	��250 �6+   �� 5W      $��45 �6+   �� 5X      $��45 �6+   �� 5Y      $��45 �6+   �� 5Z      $��45 �6+   .+�5\      � $��0��6   .+�5]      �� -   5         ��Name$ lblIme��5]       $��14(�5^       $��Right=�5_       $��Italic$�5`       $��0 8 70 0q�5a       $	��Top=�5b       6A   �� 5c      -   5        $ 
lblPrezime��5c       $��14(�5d       $��0 0 70 8q�5e       $��Right=�5f       $��Italic$�5g       $��Bottom=�5h       6D   � 5j      $��
0,0,-200,0q�6   .+�5k      �� -   5        $��Napusti��5k   %   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5l   %   $��120,15,190,15q�5m   %   .��5o   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5p   &   �� $��Center=�60   
�������Odjavite se5q   P   '  !MaterialDesignThemes.Wpf.PackIcon  5r   &      Kind$ Logout=�6>   $��Center=�5s   >   
�������$��15,0,0,0q�5u   >   $��25��5v   >   $��25��5w   >   5x   #   5y      �� 5z      -   5         ��Name$ SpustiProzor��5{   %   $��2��5z   %    0  ,MaterialDesignFloatingActionMiniAccentButton#��[  5|   %    � ToolTip$ Minimize��5}   %   $��22��5~   %   $��22��5   %   
���   �$��	150 0 0 0q�5�   %   $y�Visible=�5�   %   ��5�   %   Z� ��5�   %   Z� .��5�   "     $ WindowMinimize=�6:   $��16��5�   :   $��16��5�   :   5�      �� 5�      -   5        $ PovecajProzor1��5�   %   $��3��5�   %   #��[  5�   %   $��22��5�   %   $��22��5�   %   
���   �$��
265,0,10,5q�5�   %   $y�	Collapsed=�5�   %   ��5�   %   Z� ��5�   %   Z� .��5�   "     $ WindowMaximize=�6:   $��16��5�   :   $��16��5�   :   5�      �� 5�      -	   5        $ PovecajProzor��5�   %   $��3��5�   %   #��[  5�   %   $ 	Maximized��5�   %   $��22��5�   %   $��22��5�   %   
���   �$��	250 0 0 0q�5�   %   $y�Visible=�5�   %   ��5�   %   Z� ��5�   %   Z� .��5�   "     $ WindowMaximize=�6:   $��16��5�   :   $��16��5�   :   5�      �� 5�      -
   5        $ Izlaz��5�   %   $��4��5�   %   #��[  5�   %   $ Exit App��5�   %   ���	#FFC34A4A���	#FFC34A4A$��22��5�   %   $��22��5�   %   $��	350 0 0 0q�5�   %   $y�Visible=�5�   %   .��5�   "     $ WindowClose=�6:   $��16��5�   :   $��16��5�   :   5�      5�      5�      5�      5�      5�      � 5�   
   -   5         �Name$ StackPanelMain��5�      $��1��5�      $��1��5�      $	��Top=�5�      $��Stretch=�5�      6/   �� 5�   
   -   5         ��Name$ acceptReject��5�      $��1��5�      $��1��5�      
��� � �$��20(�5�      $��Italic$�5�      $
��Bold"�5�      $��Center=�5�      $��0 240q�5�      6%   &   System.Windows.Controls.DataGrid  5�   
   -   5          Name$ DataGridAllMenu��5�      $��1��5�      $��1��5�         
IsReadOnly . $��14(�5�      $
��auto��5�      $	��300��5�      $��10 200 10 0q�5�         MinColumnWidth$	 100Q�5�      
�������   AlternatingRowBackground
 �����$��Center=�5�         MaxColumnWidth$	 200Q�5�      $	��Top=�5�      $��Center=�5�      $y�Visible=�5�         HeadersVisibility$ Column=�5�         AutoGenerateColumns .     HorizontalGridLinesBrush
 �   �
�������$��2q�5�      
�������$��Medium"�5�      ��5�      �� *AllMenuList+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5�      �� *	AllMenu+$ PropertyChanged=�   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Torta��6%   1	  +System.Windows.Controls.DataGridBoundColumn  	  Binding  5�   %   �� *ProductName+! 	  ElementStyle! 5�      �� 5�      .�5�      �� " �� Property" �@��TextAlignment# �� Value$
# Left=�5�   %   5�      5�        5�      $ 
Cena (RSD)��6%     5�   %   �� *SellingPrice+$ �� StringFormat$$ N2��! 5�      �� 5�      .�5�      �� " � ��$
# Wrap=�5�   %   5�      5�        5�      $ 	Namenjeno��6%     5�   %   �� *
KindCake+! 5�      �� 5�      .�5�      �� " � ��$
# Wrap=�5�   %   5�      5      5     � 5  
   -   5        $ 
welcomeMsg��5     $��1��5     $��1��5     $	��Top=�5     $��Center=�5     .+�5     �� -   5        $ msgHappy��5	     $��
0 80 0 150q�5     
��� ���$��25(�5     $��Oblique$�5     $
��Bold"�5     *(Hvala vam što koristite naše usluge :)6R   �� 5     $��0 120 40 100q�6   
��� ���$��25(�5     $��Oblique$�5     $��Right=�5     $��Light"�5     L-Cake63   �� 5     $��
70 167 0 0q�6   
��� ���$��25(�5     $
��Bold"�5     $
��Left=�5     
Torta Meni6?   �� 5     -   5        $��ordering��5     $ 10��5     $	��100��5     $��25��5     $��190 105 0 0q�5     .��5     �� $ 
Horizontal=�6   .+�5      �� $��Center=�6    
�������	Poručite5!  =   5"     5#     5$     � 5&  
   $��1��6   $��2��5'     $��Right=�5(      5)     �� 5*     $
��auto �6#   �� 5+     $
��auto �6#   �� 5,     $��18 �6#   �� 5-     $
��auto �6#   �� 5.     $
��auto �6#   .+�50     �� $��0��6   $��	0,0,-10,0q�51     $
 Date��52     ��53     Z� ��54     Z� .��55       $ CalendarMonthOutline=�6*   $��25��56  *   $��25��57  *   
��� ���58  *   59     �� 5:     $��1��6   $��Center=�5;     $��15(�5<     $
��auto��5=     $��Right=�5>     ��5?     �� 
% �� Now& �� Source#& Z% ' �� ConverterCulture$' sr-SR��$$ dddd dd. MMMM yyyy.���� 5@     $��2��6   $��Stretch=�5A     $��Right=�5B     
�������$��0,5,0,5q�5D     $��1��5E     �� 5G     $��3��6   $��0,0,0,0q�5H     $
 Time��5I     $��55��5L     ��5J     Z� ��5K     Z� .��5M       $ Clock=�6*   $��25��5N  *   $��25��5O  *   
��� ���5P  *   5Q     �� 5R     -   5        $ vr��5S     $��4��5R     $
��auto��5T     $��15(�5U     $��Center=�5V     $��
-10,0,32,0q�5W     5X     5Y     5Z     