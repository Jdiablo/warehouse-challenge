import type WarehouseWingModel from "./WarehouseWingModel"

export default interface WarehouseModel {
	id: string;
	name: string;
	locationLat: string;
	locationLong: string;
	warehouseWing: WarehouseWingModel;
}
