   M S B A M L   `   `   `  ����B  >WpfApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp4WpfApp4  5   	       WpfApp4.PageBikeshering   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp4     5   	     � Title$  Байкшеринг��5   	   $	��431��6   $	��600��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      � $��426.7��6   $	��600��6   .+�5   
   �� ._�5      �� $��images/bike3.png��6   $��	0,-7,0,-8q�6.   5      �� 5   
   $��Байкшеринг��6   
�������$
��Bold"�6>   $��35(�6P   $��Center=�6^   $��10q�6{   � 5   
   $	��289��6   $	��700��6   .+�5      �� $N��HНа дачу, на море, в магазин и без пробок? ��6   
�������$��Center=�6]   $��65q�6z   $	��242��6�   �� 5      $W��QТолько на новых и быстрых элетровелосипедах��6   
�������$��Center=�6^   $��90q�6|   $	��269��6�   5      �� 5   
   $+��%Арендуйте велосипед��6   
�������$��25(�6G   $��DemiBold"�6U   $��28,135,-18,-135q�6k   �� 5   
   $��прямо сейчас��6   
�������$��25(�6@   $��DemiBold"�6N   $��28,176,-18,-176q�6d   �� 5   
   $��	Имя - ��6   $��12(�6"   
�������$��
88 245 0 0q�6C   $	��140��6W   $	��509��6g   �� 5   
   $��128,243,345,123q�6   
������� �� CornerRadius$ 7��6=   $��5��6N   $��19��6\   $	��100��6k   $	��101��6z   ._�5      �� -   5        $
��Name��5      $
��Bold"�6#   $��10(�65    �� TextAlignment$ Center=�6C    �� 	MaxLength$ 17��6Z   $��Center=�6i   $��Center=�6�   $��8,1,7,0q�6�   $	��104��6�   $��23��6�   
�������.��6  5      5       �� 5"   
   $$��Номер телефона - ��6   $��12(�6-   
�������$��
20 280 0 0q�6N   $
��Left=�6b   $	��115��6}   $	��509��6�   �� 5#   
   $��128,276,345,91q�6   
�������$ 7��6<   $��5��6M   $��19��6[   $	��100��6j   $	��101��6y   ._�5$      �� -   5        $��Phone��5$       � ToolTip$$ без +7 и 8 в начале��6#   $
��Bold"�6A   $��10(�5%      $ Center=�6$   $ 10��6;   $��Center=�6J   $��Center=�6e   $��8,1,7,0q�5&      $	��104��6'   $��22��63   
�������.��6u   5'      50      �� 51   
   $ 10��6   ���#878383$��323,135,63,43q�68    J� Opacity$ .6Q�6O   6^   � 52   
   .+�53      �� -   5        $��Арендовать��53      $
��Bold"�6*   $��180 260 0 0q�6<   $
��Left=�6Q   $��10(�6l   
���   �
�������$��29��6�   $��30��6�   $��60��6�   $��75��6�    � 	Resources 54       �� 
TargetType	 �� Property
 �� Value��%_   '��       �� 55      " ��6   .�56      �� 	 �@��CornerRadius$
 12��69   57      58      59      5:      � 5;   
   .+�5<      �� $��20 000��6   $��28(�6&   
�������$��DemiBold"�6G   $��0,151,167,215q�6^   $��Center=�6u   $��Right=�6�   �� 5=      $*��$электровелосипедов��6   $��18(�62   
�������$��DemiBold"�6S   $��10,171,75,174q�6i   $��Center=�6�   $��Right=�6�   �� 5?      $3��-У нас самый большой парк ��6   $��14(�69   
�������$
��Thin"�6Z   $��
0 100 80 0q�6m   $��Center=�6�   $��Right=�6�   �� 5@      $<��6электровелосипедов в России, ��6   $��13(�6=   
�������$
��Thin"�6^   $��0 100 72 -40q�6p   $��Center=�6�   $��Right=�6�   �� 5A      $1��+который растет с каждым��6   $��14(�68   
�������$
��Thin"�6Y   $��0 100 95 -80q�6k   $��Center=�6�   $��Right=�6�   �� 5B      $��годом ��6   $��14(�6'   
�������$
��Thin"�6H   $��0 100 202 -120q�6Z   $��Center=�6r   $��Right=�6�   $��46��6�   $��20��6�   5C      �� 5D   
   -   5        $��10,10,555,358q�5D      $��20��6B   $��55��6Q   $��20��6`   $��35��6n   ��5E      �� 5F       �� Color$ 	#FF555556��6"    �� Opacity$ 0Q�64   ��5H      �� 5I      $ 	#FF555556��6"   $ 0Q�64   .��5L      �� $��images/back.png��6    J� RenderTransformOrigin$ -0.222,0.605&�6-   5M      5N      5O      