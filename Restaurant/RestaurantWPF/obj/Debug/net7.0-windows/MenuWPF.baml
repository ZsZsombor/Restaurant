   M S B A M L   `   `   `  ����H  DRestaurantWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:RestaurantWPFRestaurantWPF  5   	       RestaurantWPF.MenuWPF   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:RestaurantWPF     5   	     � Title$  Restaurant Menu��5   
   $	��500��6"   $	��650��6/   ��5	      �� 5
   
    �� ImageSource$ /background.jpg��6   .��5      �  � 	Resources 5   
      RoundedButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%  &	        �� 5      " ��6/   .�5      ��  � �� 5      �� 5      " ��6*   .R�5      �� #��z��6%   #��z��5   !   #��z��5   !   $ 5��5   !   ._�5   "   �� $��Center=�63   $��Center=�5      5      5      5      5      5       � RowDefinitions 5   
   �� 5      $
��Auto �6   $	��125��6*   �� 5       .+�5#   
   �� $��Center=�6   $��0��61   $��0,15,0,0q�6>   $
��Bold"�6P   $��48(�6b   $	��428��6p   $��2��6|   	 �� 
LineHeight$	 48��6�   
 �� TextAlignment$
 Center=�6�   $��Expanded&�6�    �� LineStackingStrategy$ BlockLineHeight=�6�   
�������$��Viner Hand ITC)�6  $	��241��6!  $	��Top=�6.   J� Effect 5$      3  -System.Windows.Media.Effects.DropShadowEffect  5%         Color$ Black��6#      	Direction$	 -10Q�61      ShadowDepth$ 10Q�6A      
BlurRadius$ 6Q�6R      Opacity$ 22Q�6a   �� 5'      $
�Menu��6   5)      �� 5,   
   $��0,86,0,0q�6,   $��2��6>   ��6   Z� ��6O   Z�  5-       ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  '��       �� 5.      " ��6   .�5/      ��  � �� 50      �� 51      " ��6.   .R�52   "   �� $��Border��6)   $��2,2,2,2q�67   
���   �$ 5,5,5,5��6e   $	��2,0q�6|   ._�53   &   �� $ ContentSite��67   $��Center=�54   )   $��Center=�55   )   $��Header��56   )   $
��10,2q�57   )   58   #    59   "   P� 5:   &    �@��
IsSelected$
 True��6D   . �5;   *   �� $ Border��61    � �� �	#FFFFD5A66[   �� 5<   *    � ��$
 Bold"�6G   5=   '   P� 5>   &    �@��
IsSelected$ False��6D   . �5?   *   �� $ Border��61    � �� �	#FFC18F656[   5@   '   5B      5D      5E      5F      .@�5H      �� $��Előételek/Levesek��6   .��5I      �� $	��300��6   $��132,0,132,0q�6*   ��5J      �� 5K      $ /treasure-map.jpg��6%    j� Stretch$ UniformToFill=�6E   .+�5M      �� $	��370��6    $"��Tengeri Kincsek Krémlevese:��6,   $
��Bold"�6O   $��20(�6a   �� 5N      $	��350��6    $����Gazdag krémleves tengeri herkentyűkkel, például garnélarákkal, kagylókkal és tintahallal, friss fűszerekkel és egy kis rummal fűszerezve.��6,   $
��Wrap=�6�   $
��Bold"�6�   $��13(�6�   �� 5P      $��Kalózkorszak Húslevese:��6    $	��370��6?   $
��Bold"�6K   $��0,10,0,0q�6]   $��20(�6o   �� 5Q      $	��350��6    $s��mÍzletes húsleves friss zöldségekkel és marhahússal, szervírozva egy kalóz sapka formájú kenyérrel.��6,   $
��Wrap=�6�   $��13(�6�   $
��Bold"�6�   5R      5S      �� 5U      $��
Főételek��6   .��5V      �� $	��300��6   $��132, 0, 132, 0q�6*   ��5W      �� 5X      $ /treasure-map.jpg��6%   $ UniformToFill=�6E   .+�5Z      �� $	��370��6    $-��'Fekete Zászló Ropogós Halpikkelyben:��6,   $
��Bold"�6X   $��20(�6j   �� 5[      $	��350��6    $����Friss fogasfilé, melyet ropogós, fekete színű pikkelyekkel borítunk, és citromos-vajos mártással tálalunk, mellé sült krumplival és friss zöldségekkel.��6,   $
��Wrap=�6�   $��13(�6�   $
��Bold"�6�   �� 5]      $	��370��6    $$��Kalózkapitány Bárányborda:��6,   $
��Bold"�6N   $��0,10,0,0q�6`   $��20(�6r   �� 5^      $	��350��6    $����Lassan sült bárányborda, melyet egy pikáns rumos-mustáros mártással kínálunk, körítve fűszeres párolt rizzsel és grillezett zöldségekkel.��6,   $
��Wrap=�6�   $��13(�6�   $
��Bold"�6�   �� 5`      $	��370��6    $��Vad Tengeri Kalózfogás:��6,   $
��Bold"�6K   $��0,10,0,0q�6]   $��20(�6o   �� 5a      $	��350��6    $����Vegyes tenger gyümölcsei, például rákok, kagylók és homár, egy csábítóan fűszeres paradicsomos-szószban, kagylóhéjjal tálalva.��6,   $
��Wrap=�6�   $��13(�6�   $
��Bold"�6�   5b      5c      �� 5e      $��
Desszertek��6   .��5f      �� $	��300��6   $��132,0,132,0q�6*   ��5g      �� 5h      $ /treasure-map.jpg��6%   $ UniformToFill=�6E   .+�5j      �� $	��370��6    $(��"Kincses Láva: Csokoládévulkán:��6,   $
��Bold"�6R   $��20(�6d   �� 5k      $	��350��6    $����Krémes csokoládévulkán, melyből láva folyik ki, tetejét aranyhomok (sült mandula) borítja, mellé vaníliafagylalttal és friss gyümölcsökkel.��6,   $
��Wrap=�6�   $��13(�6�   $
��Bold"�6�   �� 5m      $	��370��6    $"��Kalózkincs Karamell Puding:��6,   $
��Bold"�6O   $��0,10,0,0q�6a   $��20(�6s   �� 5n      $	��350��6    $f��`Gazdag karamell puding frissen sütött rumos ananásszal és egy kis tejszínhabbal a tetején.��6,   $
��Wrap=�6�   $��13(�6�   $
��Bold"�6�   5o      5p      �� 5r      $��Italok��6   .��5s      �� $	��306��6   $��132,0,132,0q�6*   ��5t      �� 5u      $ /treasure-map.jpg��6%   $ UniformToFill=�6E   .+�5w      �� $��Kalózgyöngy Rumkoktél:��6    $
��Bold"�6>   $��20(�6P   $	��370��6^   ��5x      �� 5y      5{      �� 5|      $V��PKülönleges rumkoktél friss lime-lével és édes gyümölcsökkel díszítve.��6    $
��Wrap=�6m   $��13(�6�   $
��Bold"�6�   $	��350��6�   �� 5~      $!��Tengeri Zivatar Limonádé:��6    $
��Bold"�6A   $��0,10,0,0q�6S   $��20(�6e   $	��370��6s   �� 5      $I��CFrissítő limonádé friss mentával és tengeri gyümölcsökkel.��6    $
��Wrap=�6b   $��13(�6v   $
��Bold"�6�   $	��350��6�   �� 5�      $ ��Kalózok Vére Vörösbor:��6    $
��Bold"�6>   $��0,10,0,0q�6P   $��20(�6b   $	��370��6p   �� 5�      $\��VIllatos, testes vörösbor, melyet a kalózok kedvelték hosszú tengeri utazásaikon.��6    $
��Wrap=�6x   $��13(�6�   $
��Bold"�6�   $	��350��6�   5�      5�      5�      �� 5�   
   -   5        $
��Back��5�      $��575,88,10,14q�65   #��[  6K   $��2,2,2,2q�6w   
���   ����	#FFB38864$
��Bold"�6�   5�      5�      