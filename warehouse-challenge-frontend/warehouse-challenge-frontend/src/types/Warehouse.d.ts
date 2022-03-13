import type WarehouseWingModel from "./WarehouseWing"

export default interface WarehouseModel {
	id: string;
	name: string;
	locationLat: string;
	locationLong: string;
	warehouseWing: WarehouseWingModel;
}
