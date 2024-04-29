defmodule Lasagna do
  def expected_minutes_in_oven, do: 40

  def remaining_minutes_in_oven(actual_minutes_in_oven) do
    expected_minutes_in_oven() - actual_minutes_in_oven
  end

  def preparation_time_in_minutes(layers), do: layers * 2

  def total_time_in_minutes(layers, actual_minutes_in_oven) do
    actual_minutes_in_oven + preparation_time_in_minutes(layers)
  end

  def alarm, do: "Ding!"
end
