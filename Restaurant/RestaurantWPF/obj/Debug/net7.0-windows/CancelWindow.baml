   M S B A M L   `   `   `  ����H  DRestaurantWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:RestaurantWPFRestaurantWPF  5   	        RestaurantWPF.CancelWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:RestaurantWPF     5   	     � Title$
  Main��5   	   $	��500��6   $	��650��6#   ��5	      �� 5
   
    �� ImageSource$ /background.jpg��6   .��5      �  � 	Resources 5   
      HeaderTextStyle �� 
TargetType �� Property �� Value  RoundedButtonStyle �� 
TargetType �� CornerRadius��%�  &	        &	 �     �� 5      " ��6,   .�5      ��  � ��$ 48(�6-   �� 5       � ��$
 Bold"�6/   �� 5       � ��
 �   �6/   5      �� 5      " ��6/   .�5      ��  � �� 5      �� 5      " ��6*   .R�5      �� #��z��6%   #��z��5      #��z��5      $ 5��5      ._�5   "   �� $��Center=�63   $��Center=�5   #   5      5      5!      5"      5#      .+�5$   
   �� $��Center=�6   $	��Top=�62   $	��109��6J   $	��453��6W   .+�5%      �� $��Reservation Cancel��6   $��Center=�62   $��Center=�6P   $��48(�6k   $
��Bold"�6y   $��Viner Hand ITC)�6�   
������� J� Effect 5&      3  -System.Windows.Media.Effects.DropShadowEffect  5'      	   Color$	 Black��6'   
   	Direction$
 0Q�65      ShadowDepth$ 10Q�6C      
BlurRadius$ 10Q�6T      Opacity$ 1Q�6d   5)      5*      �� 5,   
   $ 10��6   ._�5-      ��  �� Orientation$ Vertical=�6   $��Center=�60   $��0,138,0,137q�6M   $	��190��6b    5.      ��%_   '��       �� 5/      " ��6   .�50      ��  �@��CornerRadius$ 10��69   51      52      ��53      �� 54       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��55      �  � Color$ 	#7BDD9566��6'   � 56      $ 	#7F5F3C32��6'    � Offset$ 0.785Q�69   57      .+�59      �� $��Name:��6   $��20(�6(   $
��Bold"�66   �� 5:      -   5         ��Name$ 	NameInput��5:   &   $
��Name��6   $	��180��69   $��10q�6E   .��6�    5;      ��%^   '��       �� 5<      " ��6    .�5=      ��  �@��CornerRadius$ 3��6=   5>      5?      .��6)   5@      �� 5A      $��Reservation ID:��6   $
��Bold"�62   $��20(�6D   �� 5D      -   5        $ ReservationIdInput��5D   $   $��id��6   $	��180��6@   $��10q�6L   .��6�    5E      ��%^   '��       �� 5F      " ��6    .�5G      ��  �@��CornerRadius$ 3��6=   5H      5I      .��6)   5J      5L      5M      �� 5O   
   $��Center=�6   $	��Top=�62   $ 
Horizontal=�6J   $��	0,359,0,0q�6c   .+�5P      �� -   5        $��Cancel Reservation��5P      #��[ 6G   $��35��6s   $��20(�6   $
��Bold"�6�   ���	#FFC18F65
���   �$��2,2,2,2q�6�    � Cursor$
 Hand��6�   $	��189��6�   $��5q�6�   �� 5Q      -   5        $��New Reservation��5Q      #��[ 6G   $��35��6s   $��20(�6   $
��Bold"�6�   ���	#FFC18F65
���   �$��2,2,2,2q�6�   $
 Hand��6�   $	��170��6�   $��5q�6�   5R      �� 5S   
   $��Right=�6   $��Bottom=�61   $ Vertical=�6L   $��10,10,10,10q�6c   .+�5T      �� -   5        $
��Back��5T      #��[ 61   $��35��6]   $��20(�6i   $
��Bold"�6w   ���	#FFC18F65
���   �$��2,2,2,2q�6�   $
 Hand��6�   $��80��6�   $��5q�6�   5U      5V      5W      