def leap_year(year: int) -> bool:
    """Determines if the provided year is a leap year.

    :param year: int - the year to check
    :return: bool - whether it's a leap year
    """
    return year % 400 == 0 or (year % 4 == 0 and not year % 100 == 0)
